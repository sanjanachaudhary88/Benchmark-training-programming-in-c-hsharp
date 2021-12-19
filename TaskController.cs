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
    public class TaskController : ApiController
    {
        ProjectBAL bal = new ProjectBAL();

        [HttpGet]
        public List<Task> GetTaskData()
        {
            List<Task> list = bal.GetTaskData();
            return list;
        }

        [HttpGet]
        public Task GetTaskUsingTaskId(int taskid)
        {
            Task tsk = bal.GetTaskUsingTaskId(taskid);
            return tsk;
        }

        [HttpPost]
        public int InsertTask(Task e)
        {
            int res = bal.InsertTask(e.taskid, e.taskdescription, e.status, e.start_date, e.end_date, e.empid);
            return res;
        }

        [HttpPut]
        public int UpdateTask(Task e)
        {
            int res = bal.UpdateTask(e.taskid, e.taskdescription, e.status, e.start_date, e.end_date, e.empid);
            return res;
        }

        [HttpDelete]
        public void DeleteTask(Task em)
        {
            bal.DeleteTask(em);

        }
    }
}
