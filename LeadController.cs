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
    public class LeadController : ApiController
    {
        ProjectBAL bal = new ProjectBAL();

        [HttpGet]
        public List<Lead> GetLeadData()
        {
            List<Lead> list = bal.GetLeadData();
            return list;
        }

        [HttpGet]
        public Lead GetLeadUsingLeadId(int lead_id)
        {
            Lead lm = bal.GetLeadUsingLeadId(lead_id);
            return lm;
        }
        [HttpPost]
        public void InsertLead(Lead lm)
        {

            bal.InsertLead(lm);

        }
        [HttpPut]
        public void UpdateLead(Lead lm)
        {

            bal.UpdateLead(lm);

        }
        [HttpDelete]
        public void DeleteLead(Lead lm)
        {

            bal.DeleteLead(lm);

        }
    }
}
