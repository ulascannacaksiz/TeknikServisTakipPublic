using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;



namespace TeknikServisTakip.Controllers
{
    public class DashboardController : Controller
    {
        UserProductManager upm = new UserProductManager(new EfUserProductRepository());
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var result = upm.GetMyProductList(user.Id);
            ViewBag.atanan = result.ToList();
            return View();
        }



        [HttpPost]
        public JsonResult MyProductList()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            int totalRecord = 0;
            int filterRecord = 0;
            var draw = Request.Form["draw"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = Convert.ToInt32(Request.Form["length"].FirstOrDefault() ?? "0");
            int skip = Convert.ToInt32(Request.Form["start"].FirstOrDefault() ?? "0");
            var data = upm.GetMyProductList(user.Id);

            totalRecord = data.Count();

            //Arama
            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(
                   x => x.Serviceproduct.Brand.ToLower().Contains(searchValue.ToLower()) 
                || x.Serviceproduct.Model.ToLower().Contains(searchValue.ToLower()) 
                || x.Serviceproduct.Servicestatus.StatusName.ToLower().Contains(searchValue.ToLower())).ToList();
            }

            filterRecord = data.Count();
            
            //sort data
            if (sortColumnDirection == "desc" && sortColumn == "Brand")
            {
                data = data.OrderByDescending(x => x.Serviceproduct.Brand).ToList();
            }
            else if (sortColumnDirection == "asc" && sortColumn == "Brand")
            {
                data = data.OrderBy(x => x.Serviceproduct.Brand).ToList();

            }
            else if (sortColumnDirection == "desc" && sortColumn == "Model")
            {
                data = data.OrderByDescending(x => x.Serviceproduct.Model).ToList();

            }
            else if (sortColumnDirection == "asc" && sortColumn == "Model")
            {
                data = data.OrderBy(x => x.Serviceproduct.Model).ToList();

            }
            else if (sortColumnDirection == "desc" && sortColumn == "Servicestatus")
            {
                data = data.OrderByDescending(x => x.Serviceproduct.Servicestatus).ToList();

            }
            else if (sortColumnDirection == "asc" && sortColumn == "Servicestatus")
            {
                data = data.OrderBy(x => x.Serviceproduct.Servicestatus).ToList();

            }
            else if (sortColumnDirection == "desc" && sortColumn == "LastModifedDate")
            {
                data = data.OrderByDescending(x => x.Serviceproduct.LastModifedDate).ToList();

            }
            else if (sortColumnDirection == "asc" && sortColumn == "LastModifedDate")
            {
                data = data.OrderBy(x => x.Serviceproduct.LastModifedDate).ToList();

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
    }
}

