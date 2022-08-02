using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using TeknikServisTakip.Models;

namespace TeknikServisTakip.Controllers
{
    [AllowAnonymous]
    public class GetProductController : Controller
    {

        ServiceproductManager serviceproduct = new ServiceproductManager(new EfServiceproductRepository());

        public IActionResult Index()
        {
            var sitekey = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("GoogleRecaptcha")["Sitekey"];
            ViewBag.SiteKey = sitekey;

            return View();
        }


        [HttpGet]
        public IActionResult getProductDetail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getProductDetail(Serviceproduct p)
        {

            var response = Request.Form["g-recaptcha-response"];
            var secret = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("GoogleRecaptcha")["Secret"];

            var client = new WebClient();
            var reply =
                client.DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));

            var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

            if (!captchaResponse.Success)
                TempData["Message"] = "Lütfen güvenliği doğrulayınız.";
            else
            {
                TempData["Message"] = "Güvenlik başarıyla doğrulanmıştır.";
                if (p.UniqeId != null && p.Customer.CustomerEmail != null)
                {
                    var result = serviceproduct.GetList().Find(x => x.UniqeId == p.UniqeId && x.Customer.CustomerEmail == p.Customer.CustomerEmail);
                    return View(result);
                }
            }

            return View();

        }
    }
}
