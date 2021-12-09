using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample3.BAL;
using MVCExample3.Models;


namespace MVCExample3.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        DepartmentBAL bal=new DepartmentBAL();  
        public ActionResult Index()
        {
            List<DepartmentModel> dlist = bal.GetDepartment();
            return View(dlist);
        }

        //Insert Department 

        [HttpGet]
        public ActionResult InsertDepartment()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult InsertDepartment(FormCollection collection)
        {
            try
            {
                DepartmentModel dm = new DepartmentModel();
                dm.depno = Convert.ToInt32(collection["depno"].ToString());
                dm.dname = collection["dname"].ToString();
                dm.location = collection["location"].ToString();
                bal.insertDepartment(dm);



                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["Backpage"] = "InsertDepartment";
                return RedirectToAction("ErrorPage");
            }
             
        }

        //update department

        [HttpGet]
        public ActionResult UpdateDepartment(int id)
        {
            DepartmentModel dm=bal.GetDeptusingDepno(id);   
            return View(dm);
        }

        [HttpPost]
        public ActionResult UpdateDepartment(FormCollection collection)
        {
            try
            {
                DepartmentModel dm = new DepartmentModel();
                dm.depno = Convert.ToInt32(collection["depno"].ToString());
                dm.dname = collection["dname"].ToString();
                dm.location = collection["location"].ToString();
                bal.UpdateDepartment(dm);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["Backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }

        }

        //delete department
        [HttpGet]
        public ActionResult DeleteDepartment(int id)
        {
            try
            {
                bal.DeleteDepartment(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["Backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }
        }


        [HttpGet]
        public ActionResult DetailDepartment(int id)
        {
            DepartmentModel dm = bal.GetDeptusingDepno(id);
            return View(dm);

        }




        [HttpGet]
        public ActionResult ErrorPage()
        {
            TempData.Keep("err");
            TempData.Keep("InsertDepartment");
            return View();

        }
    }
}
