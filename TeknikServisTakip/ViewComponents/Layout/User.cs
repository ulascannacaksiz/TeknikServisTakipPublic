using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TeknikServisTakip.ViewComponents.Layout
{
    public class User:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public User(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.v1 = values.Name +  " " + values.Surname;
            return View();
        }

    }
}
