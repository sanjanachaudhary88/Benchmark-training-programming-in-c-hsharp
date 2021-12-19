using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectAPI.Models;
using ProjectAPI.BAL;

namespace ProjectAPI.Controllers
{
    public class OpportunityController : ApiController
    {

        ProjectBAL bal = new ProjectBAL();

        [HttpGet]
        public List<Opportunity> GetOpportunityData()
        {
            List<Opportunity> list = bal.GetOpportunityData();
            return list;
        }

        [HttpGet]
        public Opportunity GetOpportunityUsingOppId(int oppid)
        {
            Opportunity opp = bal.GetOpportunityUsingOppId(oppid);
            return opp;
        }

        [HttpPost]
        public int InsertOpportunity(Opportunity o)
        {
            int res = bal.InsertOpportunity(o.opp_id, o.name, o.email, o.address, o.phone, o.gender, o.plan_details, o.plan_price, o.lead_id);
            return res;
        }

        [HttpPut]
        public int UpdateOpportunity(Opportunity o)
        {
            int res = bal.UpdateOpportunity(o.opp_id, o.name, o.email, o.address, o.phone, o.gender, o.plan_details, o.plan_price, o.lead_id);
            return res;
        }

        [HttpDelete]
        public void DeleteOpportunity(Opportunity o)
        {
            bal.DeleteOpportunity(o);

        }
    }
}
