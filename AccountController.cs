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
    public class AccountController : ApiController
    {
        ProjectBAL bal = new ProjectBAL();

        [HttpGet]
        public List<Account> GetAccountData()
        {
            List<Account> list = bal.GetAccountData();
            return list;
        }

        [HttpGet]
        public Account GetAccountUsingAccId(int acc_id)
        {
            Account am = bal.GetAccountUsingAccId(acc_id);
            return am;
        }
        [HttpPost]
        public void InsertAccount(Account am)
        {

            bal.InsertAccount(am);

        }
        [HttpPut]
        public void UpdateAccount(Account am)
        {

            bal.UpdateAccount(am);

        }
        [HttpDelete]
        public void DeleteAccount(Account am)
        {

            bal.DeleteAccount(am);

        }
    }
}
