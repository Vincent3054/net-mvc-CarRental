using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.Security;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //宣告Members資料表的Service物件
        private readonly RentalCarDBService rentalCarDBService = new RentalCarDBService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ContactiewModelViewModel membersData = new ContactiewModelViewModel();
            //if (User.Identity.IsAuthenticated) return RedirectToAction("Login", "Members");
            membersData.Account = Session["Account"].ToString();
            membersData.Name = Session["Name"].ToString();
            membersData.Location = Session["Location"].ToString();
            membersData.Email = Session["Email"].ToString();
            return View(membersData);
        }
        public ActionResult RentalCar(RentalCar rentalCarData)
        {
            rentalCarDBService.CreateRentalCar(rentalCarData);
            TempData["RentalCarResult"] = "預約成功";
            return RedirectToAction("RentalCarResult");
        }
        public ActionResult RentalCarResult()
        {
            return View();
        }
    }
}