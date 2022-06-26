using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class RentalCar
    {
        //車子名稱
        public string CarName { get; set; }

        //姓名
        public string Name { get; set; }

        //居住地
        public string Location { get; set; }

        //電子信箱
        public string Email { get; set; }
    }
}