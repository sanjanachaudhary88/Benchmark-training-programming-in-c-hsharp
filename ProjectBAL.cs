using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectAPI.DAL;
using ProjectAPI.Models;
using System.Data.SqlClient;

namespace ProjectAPI.BAL
{
    public class ProjectBAL
    {
        ProjectDAL dal = new ProjectDAL();

        //employee
        public List<Employee> GetEmployeeData()
        {
            SqlDataReader reader = dal.GetEmployeeData();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(reader["empid"]);
                emp.empname = Convert.ToString(reader["empname"]);
                emp.email = Convert.ToString(reader["email"]);
                emp.phone = Convert.ToInt32(reader["phone"]);
                emp.address = Convert.ToString(reader["address"]);
                list.Add(emp);
            }
            return list;
        }

        public Employee GetEmpUsingEmpId(int empid)
        {
            SqlDataReader reader = dal.GetEmpUsingEmpId(empid);
            reader.Read();
            Employee emp = new Employee();
            emp.empid = Convert.ToInt32(reader["empid"]);
            emp.empname = Convert.ToString(reader["empname"]);
            emp.email = Convert.ToString(reader["email"]);
            emp.phone = Convert.ToInt32(reader["phone"]);
            emp.address = Convert.ToString(reader["address"]);

            return emp;
        }

        public int InsertEmployee(Employee d)
        {
            int res = dal.InsertEmployee(d.empid,d.empname,d.email,d.phone,d.address);
            return res;
        }

        public int UpdateEmployee(Employee d)
        {
            int res = dal.UpdateEmployee(d.empid, d.empname, d.email, d.phone, d.address);
            return res;


        }
        public int DeleteEmployee(int empid)
        {
            int res = dal.DeleteEmployee(empid);
            return res;
        }

        //account

        public List<Account> GetAccountData()
        {
            SqlDataReader reader = dal.GetAccountData();
            List<Account> list = new List<Account>();
            while (reader.Read())
            {
                Account ac = new Account();
                ac.acc_id = Convert.ToInt32(reader["acc_id"]);
                ac.lead_id = Convert.ToInt32(reader["lead_id"]);
                ac.opp_id = Convert.ToInt32(reader["opp_id"]);
                ac.created_by = Convert.ToString(reader["created_by"]);
                ac.created_on = Convert.ToString(reader["created_on"]);
                ac.status = Convert.ToString(reader["status"]);

                list.Add(ac);
            }
            return list;
        }

        public Account GetAccountUsingAccId(int acc_id)
        {
            SqlDataReader reader = dal.GetAccountUsingAccId(acc_id);
            reader.Read();

            Account ac = new Account();
            ac.acc_id = Convert.ToInt32(reader["acc_id"]);
            ac.lead_id = Convert.ToInt32(reader["lead_id"]);
            ac.opp_id = Convert.ToInt32(reader["opp_id"]);
            ac.created_by = Convert.ToString(reader["created_by"]);
            ac.created_on = Convert.ToString(reader["created_on"]);
            ac.status = Convert.ToString(reader["status"]);

            return ac;
        }
        public int InsertAccount(Account d)
        {
            int res = dal.InsertAccount(d.acc_id, d.lead_id, d.opp_id, d.created_by, d.created_on, d.status);
            return res;
        }
        public int UpdateAccount(Account d)
        {
            int res = dal.UpdateAccount(d.acc_id, d.lead_id, d.opp_id, d.created_by, d.created_on, d.status);
            return res;
        }
        public int DeleteAccount(Account d)
        {
            int res = dal.DeleteAccount(d.acc_id);
            return res;
        }

        //lead
        public List<Lead> GetLeadData()
        {
            SqlDataReader reader = dal.GetLeadData();
            List<Lead> list = new List<Lead>();
            while (reader.Read())
            {
                Lead ld = new Lead();
                ld.lead_id = Convert.ToInt32(reader["lead_id"]);
                ld.name = Convert.ToString(reader["name"]);
                ld.email = Convert.ToString(reader["email"]);
                ld.address = Convert.ToString(reader["address"]);
                ld.phone = Convert.ToInt32(reader["phone"]);
                ld.gender = Convert.ToString(reader["gender"]);
                ld.status = Convert.ToString(reader["status"]);
                ld.empid = Convert.ToInt32(reader["empid"]);

                list.Add(ld);
            }
            return list;
        }

        public Lead GetLeadUsingLeadId(int lead_id)
        {
            SqlDataReader reader = dal.GetLeadUsingLeadId(lead_id);
            reader.Read();

            Lead ld = new Lead();
            ld.lead_id = Convert.ToInt32(reader["lead_id"]);
            ld.name = Convert.ToString(reader["name"]);
            ld.email = Convert.ToString(reader["email"]);
            ld.address = Convert.ToString(reader["address"]);
            ld.phone = Convert.ToInt32(reader["phone"]);
            ld.gender = Convert.ToString(reader["gender"]);
            ld.status = Convert.ToString(reader["status"]);
            ld.empid = Convert.ToInt32(reader["empid"]);

            return ld;
        }
        public int InsertLead(Lead d)
        {
            int res = dal.InsertLead(d.lead_id, d.name, d.email, d.address, d.phone, d.gender, d.status, d.empid);
            return res;
        }
        public int UpdateLead(Lead d)
        {
            int res = dal.UpdateLead(d.lead_id, d.name, d.email, d.address, d.phone, d.gender, d.status, d.empid);
            return res;
        }
        public int DeleteLead(Lead d)
        {
            int res = dal.DeleteLead(d.lead_id);
            return res;
        }



        //opportunity


        public List<Opportunity> GetOpportunityData()
        {
            SqlDataReader reader = dal.GetOpportunityData();
            List<Opportunity> list = new List<Opportunity>();
            while (reader.Read())
            {
                Opportunity opp = new Opportunity();
                opp.opp_id = Convert.ToInt32(reader["opp_id"]);
                opp.name = reader["name"].ToString();
                opp.email = reader["email"].ToString();
                opp.address = reader["address"].ToString();
                opp.phone = Convert.ToInt32(reader["phone"]);
                opp.gender = reader["gender"].ToString();
                opp.plan_details = reader["plan_details"].ToString();
                opp.plan_price = reader["plan_price"].ToString();
                opp.lead_id = Convert.ToInt32((reader["lead_id"].ToString() == "") ? "0" : reader["lead_id"].ToString());
                list.Add(opp);

            }
            return list;
        }

        public Opportunity GetOpportunityUsingOppId(int oppid)
        {
            SqlDataReader reader = dal.GetOpportunityUsingOppId(oppid);
            Opportunity opp = null;
            while (reader.Read())
            {
                opp = new Opportunity();
                opp.opp_id = Convert.ToInt32(reader["opp_id"]);
                opp.name = reader["name"].ToString();
                opp.email = reader["email"].ToString();
                opp.address = reader["address"].ToString();
                opp.phone = Convert.ToInt32(reader["phone"]);
                opp.gender = reader["gender"].ToString();
                opp.plan_details = reader["plan_details"].ToString();
                opp.plan_price = reader["plan_price"].ToString();
                opp.lead_id = Convert.ToInt32(reader["lead_id"]);
            }
            return opp;
        }

        public int InsertOpportunity(int oppid, string oname, string oemail, string add, int ophone, string ogender, string plandetails, string planprice, int leadid)
        {
            try
            {
                Opportunity o = new Opportunity() { opp_id = oppid, name = oname, email = oemail, address = add, phone = ophone, gender = ogender, plan_details = plandetails, plan_price = planprice, lead_id = leadid };
                dal.InsertOpportunity(o);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int UpdateOpportunity(int oppid, string oname, string oemail, string add, int ophone, string ogender, string plandetails, string planprice, int leadid)
        {
            try
            {
                Opportunity o = new Opportunity() { opp_id = oppid, name = oname, email = oemail, address = add, phone = ophone, gender = ogender, plan_details = plandetails, plan_price = planprice, lead_id = leadid };
                dal.UpdateOpportunity(o);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
                return 0;
            }
        }
        public int DeleteOpportunity(Opportunity o)
        {
            int res = dal.DeleteOpportunity(o.opp_id);
            return res;
        }




        //task

        public List<Task> GetTaskData()
        {
            SqlDataReader reader = dal.GetTaskData();
            List<Task> list = new List<Task>();
            while (reader.Read())
            {
                Task tsk = new Task();
                tsk.taskid = Convert.ToInt32(reader["taskid"]);
                tsk.taskdescription = reader["taskdescription"].ToString();
                tsk.status = reader["status"].ToString();
                tsk.start_date = reader["start_date"].ToString();
                tsk.end_date = reader["end_date"].ToString();
                tsk.empid = Convert.ToInt32(reader["empid"]);
                list.Add(tsk);

            }
            return list;
        }

        public Task GetTaskUsingTaskId(int taskid)
        {
            SqlDataReader reader = dal.GetTaskUsingTaskId(taskid);
            Task tsk = null;
            while (reader.Read())
            {
                tsk = new Task();
                tsk.taskid = Convert.ToInt32(reader["taskid"]);
                tsk.taskdescription = reader["taskdescription"].ToString();
                tsk.status = reader["status"].ToString();
                tsk.start_date = reader["start_date"].ToString();
                tsk.end_date = reader["end_date"].ToString();
                tsk.empid = Convert.ToInt32(reader["empid"]);
            }
            return tsk;
        }

        public int InsertTask(int task_id, string desc, string taskstatus, string startdate, string enddate, int empno)
        {
            try
            {
                Task e = new Task() { taskid = task_id, taskdescription = desc, status = taskstatus, start_date = startdate, end_date = enddate, empid = empno };
                dal.InsertTask(e);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int UpdateTask(int task_id, string desc, string taskstatus, string startdate, string enddate, int empno)
        {
            try
            {
                Task e = new Task() { taskid = task_id, taskdescription = desc, status = taskstatus, start_date = startdate, end_date = enddate, empid = empno };
                dal.UpdateTask(e);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int DeleteTask(Task d)
        {
            int res = dal.DeleteTask(d.taskid);
            return res;
        }
    }
}