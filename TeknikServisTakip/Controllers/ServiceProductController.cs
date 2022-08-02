using Microsoft.Extensions.Configuration;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace TeknikServisTakip.Controllers
{
    public class ServiceProductController : Controller
    {
        ServiceproductManager serviceProductManager = new ServiceproductManager(new EfServiceproductRepository());
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());
        ServicestatusManager ssm = new ServicestatusManager(new EfServicestatusRepository());
        UserProductManager upm = new UserProductManager(new EfUserProductRepository());
        private readonly UserManager<AppUser> _userManager;
        
        
        public void MailSender(string email,string title,string content)
        {
            var EmailAddress = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("EmailSettings")["Email"];
            var Password = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("EmailSettings")["Password"];
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.To.Add(email);
            mail.From = new MailAddress(EmailAddress, title, System.Text.Encoding.UTF8);
            mail.Subject = title;
            mail.Body = content;
            mail.IsBodyHtml = true;
            SmtpClient smp = new SmtpClient();
            smp.Credentials = new NetworkCredential(EmailAddress, Password);
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";
            smp.EnableSsl = true;
            smp.Send(mail);
        }

        public ServiceProductController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //var values = serviceProductManager.GetList();
            return View();
        }

        [HttpPost]
        public JsonResult MyCustomerList()
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
                var data = serviceProductManager.GetList();

                totalRecord = data.Count();

                //Arama
                if (!string.IsNullOrEmpty(searchValue))
                {
                    data = data.Where(
                       x => x.Customer.CustomerName.ToLower().Contains(searchValue.ToLower())
                    || x.Customer.CustomerSurname.ToLower().Contains(searchValue.ToLower())
                    || x.Brand.ToLower().Contains(searchValue.ToLower())
                    || x.Model.ToLower().Contains(searchValue.ToLower())
                    || x.Customer.CustomerEmail.ToLower().Contains(searchValue.ToLower())).ToList();
                }

                filterRecord = data.Count();

                //sort data

                if (sortColumnDirection == "desc" && sortColumn == "CustomerName")
                {
                    data = data.OrderByDescending(x => x.Customer.CustomerName).ToList();
                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerName")
                {
                    data = data.OrderBy(x => x.Customer.CustomerName).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "CustomerSurname")
                {
                    data = data.OrderByDescending(x => x.Customer.CustomerSurname).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerSurname")
                {
                    data = data.OrderBy(x => x.Customer.CustomerSurname).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "CustomerEmail")
                {
                    data = data.OrderByDescending(x => x.Customer.CustomerEmail).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerEmail")
                {
                    data = data.OrderBy(x => x.Customer.CustomerEmail).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Brand")
                {
                    data = data.OrderByDescending(x => x.Brand).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Brand")
                {
                    data = data.OrderBy(x => x.Brand).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Model")
                {
                    data = data.OrderByDescending(x => x.Model).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Model")
                {
                    data = data.OrderBy(x => x.Model).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Price")
                {
                    data = data.OrderByDescending(x => x.Price).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Price")
                {
                    data = data.OrderBy(x => x.Price).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "StatusName")
                {
                    data = data.OrderByDescending(x => x.Servicestatus.StatusName).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "StatusName")
                {
                    data = data.OrderBy(x => x.Servicestatus.StatusName).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Problem")
                {
                    data = data.OrderByDescending(x => x.Problem).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "Problem")
                {
                    data = data.OrderBy(x => x.Problem).ToList();

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



        [HttpGet]
        public IActionResult AddProduct()
        {
           
            ViewBag.customers = cm.GetList();
            ViewBag.status = ssm.GetList();
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Serviceproduct p)
        {
            ViewBag.customers = cm.GetList();
            ViewBag.status = ssm.GetList();
            var customer = cm.TGetById(p.CustomerId);

            p.CreateDate = DateTime.Now;
            Random rnd = new Random();
            p.UniqeId = rnd.Next(111111111, 999999999).ToString();
            serviceProductManager.TAdd(p);
            string Link = $"{this.Request.Scheme}://{this.Request.Host}/GetProduct/Index";
            string content = "Sayın " + customer.CustomerName + " " + customer.CustomerSurname + " "+
                p.CreateDate + " Tarihinde "+ p.Brand + " Marka "+ p.Model + " Model ürününüzün kayıdı oluşturulmuştur. Ürününüzün durumunu sorgulamak Altaki bağlatıya tıklayabilisiniz.Takip Numarası:"+ p.UniqeId + " " + Link;
            MailSender(customer.CustomerEmail, "Servis Kayıdı Oluşturuldu", content);
            return View();
        }

        [HttpPost]
        public IActionResult GetProductDetailWithId([FromBody] Serviceproduct serviceproduct)
        {
            var values = serviceProductManager.GetProductDetailById(serviceproduct.Id);
            var customers = cm.GetList();
            var statues = ssm.GetList();

            var genericData = new { product = values, customer = customers, status = statues };

            return Json(genericData);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Serviceproduct p)
        {
            var old_data = serviceProductManager.TGetById(p.Id);
            p.CreateDate = old_data.CreateDate;
            p.LastModifedDate = DateTime.Now;
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var userProductList = upm.GetList();
            var customer = cm.TGetById(p.CustomerId);
            var status = ssm.GetList().Where(a => a.Id == p.ServicestatusId).FirstOrDefault();


            //UserProduct tablosuna sürekli aynı veri eklenmesin diye
       
            var result = userProductList.Where(x => x.ServiceproductId == p.Id);
            if (result.Count() == 0)
            {
                UserProduct userProduct = new UserProduct
                {
                    ServiceproductId = p.Id,
                    UserId = user.Id,
                };
                upm.TAdd(userProduct);

            }
            string Link = $"{this.Request.Scheme}://{this.Request.Host}/GetProduct/Index";
            string content = "Sayın " + customer.CustomerName + " " + customer.CustomerSurname + " " +
                p.LastModifedDate + " Tarihinde " + p.Brand + " Marka " + p.Model + " Model ürününüze " + status.StatusName + "İşlemi yapılmıştır." + "Ürününüzün durumunu sorgulamak Altaki bağlatıya tıklayabilisiniz.Takip Numarası:" + p.UniqeId + " " + Link;
            MailSender(customer.CustomerEmail, status.StatusName, content);

            serviceProductManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
