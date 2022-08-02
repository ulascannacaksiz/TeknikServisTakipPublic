using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace TeknikServisTakip.Controllers
{
    public class CustomerController : Controller
    {
        CityManager cm = new CityManager(new EfCityRepository());
        DistirictManager dm = new DistirictManager(new EfDistrictRepository());
        CustomerManager csm = new CustomerManager(new EfCustomerRepository());
        public IActionResult Index()
        {
           // var values = csm.GetList();
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
                var data = csm.GetList();

                totalRecord = data.Count();

                //Arama
                if (!string.IsNullOrEmpty(searchValue))
                {
                    data = data.Where(
                       x => x.CustomerName.ToLower().Contains(searchValue.ToLower())
                    || x.CustomerSurname.ToLower().Contains(searchValue.ToLower())
                    || x.CustomerEmail.ToLower().Contains(searchValue.ToLower())).ToList();
                }

                filterRecord = data.Count();

                //sort data

                if (sortColumnDirection == "desc" && sortColumn == "CustomerName")
                {
                    data = data.OrderByDescending(x => x.CustomerName).ToList();
                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerName")
                {
                    data = data.OrderBy(x => x.CustomerName).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "CustomerSurname")
                {
                    data = data.OrderByDescending(x => x.CustomerSurname).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerSurname")
                {
                    data = data.OrderBy(x => x.CustomerSurname).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "CustomerEmail")
                {
                    data = data.OrderByDescending(x => x.CustomerEmail).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "CustomerEmail")
                {
                    data = data.OrderBy(x => x.CustomerEmail).ToList();

                }
                else if (sortColumnDirection == "desc" && sortColumn == "Address")
                {
                    data = data.OrderByDescending(x => x.Address).ToList();

                }
                else if (sortColumnDirection == "asc" && sortColumn == "LastModifedDate")
                {
                    data = data.OrderBy(x => x.Address).ToList();

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



        public JsonResult GetDistiric(int id)
        {
            var values = dm.GetCityDistricts(id);
            return Json(values);
        }
        [HttpGet]
        public IActionResult CustomerAdd()
        {
            ViewBag.City = cm.GetList();
            return View();
        }

        [HttpPost]
        public IActionResult CustomerAdd(Customer p)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult validationResult = customerValidator.Validate(p);

            ViewBag.City = cm.GetList();
            if (validationResult.IsValid)
            {
                csm.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
            
            
        }

        [HttpPost]
        public JsonResult GetUserById([FromBody] Customer customer)
        {
            var user = csm.TGetById(customer.CustomerId);
            var cityId = dm.TGetById(user.DistrictId).CityId;
            var cityDistrict = dm.GetCityDistricts(cityId);
            var cities = cm.GetList();
            var selectedCity = cities.Find(x=>x.Id == cityId);
            var selectedDiscrint = cityDistrict.Find(x=>x.Id == user.DistrictId);
            var genericResult = new { User = user, CityDistrict = cityDistrict, Cities = cities, SelectedCity= selectedCity, SelectedDiscrint= selectedDiscrint };

            return Json(genericResult);
        }

        [HttpPost]
        public IActionResult CustomerUpdate(Customer p) 
        {
           csm.TUpdate(p);
           return RedirectToAction("Index");
        }

    }
}
