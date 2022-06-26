using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class RentalCarDBService
    {
        //建立與資料庫的連線字串
        private readonly static string cnstr = ConfigurationManager.ConnectionStrings["ASP.NET MVC"].ConnectionString;
        //建立與資料庫的連線
        private readonly SqlConnection conn = new SqlConnection(cnstr);
        #region 新增租車資訊
        //新增租車資訊
        public void CreateRentalCar(RentalCar rentalCarData)
        {
            //將密碼Hash過
            //sql新增語法 //IsAdmin 預設為0
            string sql = $@" INSERT INTO RentalCar (CarName,Name,Location,Email) VALUES (N'{rentalCarData.CarName}',N'{rentalCarData.Name}',N'{rentalCarData.Location}','{rentalCarData.Email}') ";
            //確保程式不會因執行錯誤而整個中斷
            try
            {
                //開啟資料庫連線
                conn.Open();
                //執行Sql指令
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //丟出錯誤
                throw new Exception(e.Message.ToString());
            }
            finally
            {
                //關閉資料庫連線
                conn.Close();
            }
        }
        #endregion
    }

}