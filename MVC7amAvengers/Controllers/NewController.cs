using MVC7amAvengers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amAvengers.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public string helloWorld()
        {
            return "Welcome To MVC";
        }

        public ActionResult getmeThanos()
        {
            return Redirect("http://www.google.com");
        }

        [Route("Pune/Superman")]
        [Route("Pune/CoronaVirus")]
        public ActionResult getmeThanos2()
        {
            return Content("Welcome to jungle");
        }

        public ActionResult getmeThanos3()
        {
            return Content("<p style='color:red'>Welcome to MVC1</p>");
        }

        public string getMeId(int? Id)
        {
            return "My Emp Id Is:" + Id;
        }

        public ActionResult sendinfo()
        {
            ViewBag.info = "corona";
            return View();
        }

        public ActionResult sendinfo2()
        {
            EmployeeModel obj = new Models.EmployeeModel();

            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            ViewBag.info = obj;
            return View();
        }

        public ActionResult sendinfo3()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);

            ViewBag.info = empList;
            return View();
        }

        public ActionResult sendinfo4()
        {
            EmployeeModel obj = new EmployeeModel();
            
                obj.EmpId = 1;
                obj.EmpName = "Prathyusha";
                obj.EmpSalary = 89493;
            

            return View(obj);
        }
        public ActionResult sendinfo5()
        {
            EmployeeModel obj = new EmployeeModel();

            obj.EmpId = 1;
            obj.EmpName = "Prathyusha";
            obj.EmpSalary = 89493;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Neerja";
            obj1.EmpSalary = 79493;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sai";
            obj2.EmpSalary = 59493;


            List<EmployeeModel> empList = new List<EmployeeModel>();
            empList.Add(obj);
            empList.Add(obj1);
            empList.Add(obj2);



            return View(empList);
        }

        public ViewResult sendinfo6()
        {
            

            return View();
        }

    }
}