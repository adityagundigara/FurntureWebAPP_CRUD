using FurntureWebAPP_ASP_NET_CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.Controllers
{
    public class HomeController : Controller
    {
        public LoginRegisterDbContext DbContext;

        public HomeController(LoginRegisterDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {

                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserTbl user)
        {
            var myuser = DbContext.UserTbls.Where(x => x.UserEmail == user.UserEmail && x.Password == user.Password).FirstOrDefault();
            if (myuser != null)
            {
                HttpContext.Session.SetString("UserSession", myuser.UserEmail);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "login failed";
            }

            return View();
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
                return RedirectToAction("List", "ProductCTR");
            }
            else
            {
                return RedirectToAction("Login");
            }

            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }

            return View();
        }

        public IActionResult Register()
        {
            
            return View();                                                                         
        }

        [HttpPost]
        public async Task< IActionResult > Register(UserTbl user)
        {
            if(ModelState.IsValid)
            {

                    await DbContext.UserTbls.AddAsync(user);
                    await DbContext.SaveChangesAsync();
                    TempData["success"] = "successfully registered";
                    return RedirectToAction("Login");

            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
