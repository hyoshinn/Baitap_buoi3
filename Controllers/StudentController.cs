using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult ShowKQ(string mssv, string hoTen, double diemTB, string chuyenNganh)
        {
            
            TempData["MSSV"] = mssv;
            TempData["HoTen"] = hoTen;
            TempData["ChuyenNganh"] = chuyenNganh;

           
            var registeredStudents = GetRegisteredStudents(chuyenNganh);
            TempData["SoLuong"] = registeredStudents.Count;

            return View();
        }

        private List<string> GetRegisteredStudents(string chuyenNganh)
        {
           
            var registeredList = new List<string>
            {
                "MSSV1", "MSSV2", "MSSV3" 
            };

            return registeredList.Where(x => x == chuyenNganh).ToList();
        }
    }
}
