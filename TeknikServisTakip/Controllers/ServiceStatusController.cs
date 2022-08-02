using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TeknikServisTakip.Controllers
{
    public class ServiceStatusController : Controller
    {
        ServicestatusManager ssm = new ServicestatusManager(new EfServicestatusRepository());
        public IActionResult Index()
        {
            var result = ssm.GetList();
            return View(result);
        }

        [HttpPost]
        public JsonResult GetStatusById([FromBody] Servicestatus servicestatus)
        {
            var result = ssm.TGetById(servicestatus.Id);
            return Json(result);
        }
        [HttpPost]
        public IActionResult UpdateStatus(Servicestatus p)
        {
            ssm.TUpdate(p);
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult AddStatus(Servicestatus p)
        {
            ssm.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
