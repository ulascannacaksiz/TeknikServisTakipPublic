using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TeknikServisTakip.Models;

namespace TeknikServisTakip.Controllers
{
    public class UserController : Controller
    {
        

        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public UserController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UserManagement()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> GetUserDetailWithId([FromBody] AppUser appUser)
        {
            var user = await _userManager.FindByIdAsync(appUser.Id.ToString());
            return Json(user);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult UserManagementGetList()
        {
            try
            {
                int totalRecord = 0;
                int filterRecord = 0;
                var draw = Request.Form["draw"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = Convert.ToInt32(Request.Form["length"].FirstOrDefault() ?? "0");
                int skip = Convert.ToInt32(Request.Form["start"].FirstOrDefault() ?? "0");
                var data = _userManager.Users.ToList();



                totalRecord = data.Count();

                //Arama
                if (!string.IsNullOrEmpty(searchValue))
                {
                    data = data.Where(
                       x => x.Name.ToLower().Contains(searchValue.ToLower())
                    || x.Surname.ToLower().Contains(searchValue.ToLower())
                    || x.Email.ToLower().Contains(searchValue.ToLower())).ToList();
                }

                filterRecord = data.Count();

                //sort data

                if (sortColumnDirection == "desc" && sortColumn == "Name")
                {
                    data = data.OrderByDescending(x => x.Name).ToList();
                }
                else if (sortColumnDirection == "asc" && sortColumn == "Name")
                {
                    data = data.OrderBy(x => x.Name).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Surname")
                {
                    data = data.OrderByDescending(x => x.Surname).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Surname")
                {
                    data = data.OrderBy(x => x.Surname).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Email")
                {
                    data = data.OrderByDescending(x => x.Email).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Email")
                {
                    data = data.OrderBy(x => x.Email).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "PhoneNumber")
                {
                    data = data.OrderByDescending(x => x.PhoneNumber).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "PhoneNumber")
                {
                    data = data.OrderBy(x => x.PhoneNumber).ToList();

                }
                //pagination
                var empList = data.Skip(skip).Take(pageSize).ToList();
                var returnObj = new
                {
                    draw = draw,
                    recordsTotal = totalRecord,
                    recordsFiltered = filterRecord,
                    data = empList
                };
                return Json(returnObj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userResult = await _userManager.FindByEmailAsync(viewModel.email);
                if (userResult != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(userResult, viewModel.password, false, true);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError(nameof(LoginViewModel.email), "Email yada Şifre Hatalı");
                    }
                }
                

            }
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddUser()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    Name = p.Name,
                    Surname  = p.Surname,
                    Email = p.Email,
                    UserName = p.Username,
                    PhoneNumber = p.Phone
                };
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    ViewBag.State = true;
                }
                else
                {
                    ViewBag.State = false;
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> UpdateUser(UserUpdateViewModel p)
        {
            var user = await _userManager.FindByIdAsync(p.id.ToString());
            if (ModelState.IsValid)
            {
                user.Name = p.Name;
                user.Surname = p.Surname;
                user.PhoneNumber = p.Phone;
                if (p.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                }
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            return Json(null);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult ResetPassword()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel p)
        {
            var user = await _userManager.FindByEmailAsync(p.Email);
            if(user != null)
            {
                var EmailAddress = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("EmailSettings")["Email"];
                var Password = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("EmailSettings")["Password"];



                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                token  = HttpUtility.UrlEncode(token);
                var link = Url.Action("UpdatePassword", "User", new { token, email = user.Email }, Request.Scheme);

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.To.Add(user.Email);
                mail.From = new MailAddress(EmailAddress, "Şifre Güncelleme", System.Text.Encoding.UTF8);
                mail.Subject = "Şifre Güncelleme Talebi";

                mail.Body = link;
                mail.IsBodyHtml = true;
                SmtpClient smp = new SmtpClient();
                smp.Credentials = new NetworkCredential(EmailAddress, Password);
                smp.Port = 587;
                smp.Host = "smtp.gmail.com";
                smp.EnableSsl = true;
                smp.Send(mail);

                ViewBag.State = true;
            }
            else
                ViewBag.State = false;
            return View();
        }

        [AllowAnonymous]
        public IActionResult UpdatePassword(string token, string email)
        {
            var model = new UpdatePasswordViewModel { Token = token, Email = email };
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> UpdatePassword (UpdatePasswordViewModel p)
        {

            var user = await _userManager.FindByEmailAsync(p.Email);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, HttpUtility.UrlDecode(p.Token), p.Password);
            if (result.Succeeded)
            {
                ViewBag.State = true;
               // await _userManager.UpdateSecurityStampAsync(user);
            }
            else
                ViewBag.State = false;
            return View();
        }

        public async  Task<IActionResult> MyAccount()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var model = new UserUpdateViewModel { Email =user.Email,Name=user.Name,Surname=user.Surname,Phone=user.PhoneNumber};
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> MyAccount(UserUpdateViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                user.Name = p.Name;
                user.Surname = p.Surname;
                user.PhoneNumber = p.Phone;
                if (p.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                }
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    ViewBag.State = true;
                }
                else
                {
                    ViewBag.State = false;
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
