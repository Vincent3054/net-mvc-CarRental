using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Services;
using WebApplication1.ViewModels;
namespace WebApplication1.Controllers
{
    public class RentalRankingControllerr : Controller
    {
        //宣告Members資料表的Service物件
        private readonly MembersDBService membersService = new MembersDBService();

        public ActionResult Index()
        {

            return View();
        }
    }
}
