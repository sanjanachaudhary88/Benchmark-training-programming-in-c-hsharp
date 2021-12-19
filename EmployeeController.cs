using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectAPI.BAL;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        ProjectBAL bal = new ProjectBAL();

        [HttpGet]
        public List<Employee> GetEmployeeData()
        {
            List<Employee> list = bal.GetEmployeeData();
            return list;
        }

        [HttpGet]
        public Employee GetEmpUsingEmpId(int empid)
        {
            Employee emp = bal.GetEmpUsingEmpId(empid);
            return emp;
        }


        [HttpPost]
        public void InsertEmployee(Employee em)
        {
            bal.InsertEmployee(em);
        }

        [HttpPut]
        public void UpdateEmployee(Employee em)
        {
            bal.UpdateEmployee(em);
        }

        [HttpDelete]
        public int DeleteEmployee(Employee em)
        {
            int emp = bal.DeleteEmployee(em.empid);
            return emp;
            //bal.DeleteEmployee(empid);
              
        }
    }
}
