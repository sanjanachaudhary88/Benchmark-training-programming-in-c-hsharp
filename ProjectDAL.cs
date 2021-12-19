using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ProjectAPI.Models;

namespace ProjectAPI.DAL
{
    public class ProjectDAL
    {
        //employee
        public SqlDataReader GetEmployeeData()
        {
            SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetEmployeeData", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetEmpUsingEmpId(int empid)
        {
            SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetEmpUsingEmpId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("empid", empid);
            cmd.Parameters.Add(param);

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
           
        }

        public int InsertEmployee(int empid, string empname, string email, int phone,string address)
        {
            
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empid", empid);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        public int UpdateEmployee(int empid, string empname, string email, int phone, string address)
        {

            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empid", empid);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        public int DeleteEmployee(int empid)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empid", empid);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }


        //Account

        public SqlDataReader GetAccountData()
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAccountData", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetAccountUsingAccId(int acc_id)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAccountUsingAccId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("acc_id", acc_id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public int InsertAccount(int acc_id, int lead_id, int opp_id, string created_by, string created_on, string status)
        {

            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("acc_id", acc_id);
                cmd.Parameters.AddWithValue("lead_id", lead_id);
                cmd.Parameters.AddWithValue("opp_id", opp_id);

                cmd.Parameters.AddWithValue("created_by", created_by);
                cmd.Parameters.AddWithValue("created_on", created_on);
                cmd.Parameters.AddWithValue("status", status);




                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int UpdateAccount(int acc_id, int lead_id, int opp_id, string created_by, string created_on, string status)
        {

            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("acc_id", acc_id);
                cmd.Parameters.AddWithValue("opp_id", opp_id);
                cmd.Parameters.AddWithValue("lead_id", lead_id);
                cmd.Parameters.AddWithValue("created_by", created_by);
                cmd.Parameters.AddWithValue("created_on", created_on);
                cmd.Parameters.AddWithValue("status", status);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int DeleteAccount(int acc_id)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("acc_id", acc_id);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        //lead

        public SqlDataReader GetLeadData()
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetLeadData", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetLeadUsingLeadId(int lead_id)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetLeadUsingLeadId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("lead_id", lead_id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public int InsertLead(int lead_id, string name, string email, string address, int phone, string gender, string status, int empid)
        {

            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("lead_id", lead_id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("empid", empid);




                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int UpdateLead(int lead_id, string name, string email, string address, int phone, string gender, string status, int empid)
        {

            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("lead_id", lead_id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("empid", empid);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int DeleteLead(int lead_id)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("lead_id", lead_id);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        //opportunity

        public SqlDataReader GetOpportunityData()
        {
            SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetOpportunityData", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        //public SqlDataReader GetOpportunityUsingOppId(int opp_id)
        //{
        //    SqlDataReader dr = null;
        //    SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("GetOpportunityUsingOppId", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("opp_id", opp_id);
        //    dr = cmd.ExecuteReader();
        //    return dr;
        //}

        
         public SqlDataReader GetOpportunityUsingOppId(int opp_id)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetOpportunityUsingOppId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("opp_id", opp_id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
         
        public void InsertOpportunity(Opportunity o)
        {
            SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("InsertOpportunity", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("opp_id", o.opp_id);
            cmd.Parameters.AddWithValue("name", o.name);
            cmd.Parameters.AddWithValue("email", o.email);
            cmd.Parameters.AddWithValue("address", o.address);
            cmd.Parameters.AddWithValue("phone", o.phone);
            cmd.Parameters.AddWithValue("gender", o.gender);
            cmd.Parameters.AddWithValue("plan_details", o.plan_details);
            cmd.Parameters.AddWithValue("plan_price", o.plan_price);
            cmd.Parameters.AddWithValue("lead_id", o.lead_id);

            cmd.ExecuteNonQuery();
        }
        public void UpdateOpportunity(Opportunity o)
        {
            SqlConnection conn = new SqlConnection("server=.;database=ProjectDB;trusted_connection=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateOpportunity", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("opp_id", o.opp_id);
            cmd.Parameters.AddWithValue("name", o.name);
            cmd.Parameters.AddWithValue("email", o.email);
            cmd.Parameters.AddWithValue("address", o.address);
            cmd.Parameters.AddWithValue("phone", o.phone);
            cmd.Parameters.AddWithValue("gender", o.gender);
            cmd.Parameters.AddWithValue("plan_details", o.plan_details);
            cmd.Parameters.AddWithValue("plan_price", o.plan_price);
            cmd.Parameters.AddWithValue("lead_id", o.lead_id);

            cmd.ExecuteNonQuery();
        }
        public int DeleteOpportunity(int oppid)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteOpportunity", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("opp_id", oppid);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }




        //task
        public SqlDataReader GetTaskData()
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetTaskData", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetTaskUsingTaskId(int taskid)
        {
            SqlDataReader dr = null;
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetTaskUsingTaskId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("taskid", taskid);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public void InsertTask(Task e) 
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("InsertTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("taskid", e.taskid);
            cmd.Parameters.AddWithValue("taskdescription", e.taskdescription);
            cmd.Parameters.AddWithValue("status", e.status);
            cmd.Parameters.AddWithValue("start_date", e.start_date);
            cmd.Parameters.AddWithValue("end_date", e.end_date);
            cmd.Parameters.AddWithValue("empid", e.empid);

            cmd.ExecuteNonQuery();
        }
        public void UpdateTask(Task e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=ProjectDB;trusted_connection=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("taskid", e.taskid);
            cmd.Parameters.AddWithValue("taskdescription", e.taskdescription);
            cmd.Parameters.AddWithValue("status", e.status);
            cmd.Parameters.AddWithValue("start_date", e.start_date);
            cmd.Parameters.AddWithValue("end_date", e.end_date);
            cmd.Parameters.AddWithValue("empid", e.empid);

            cmd.ExecuteNonQuery();
        }
        public int DeleteTask(int taskid)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=ProjectDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteTask", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("taskid", taskid);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

    }
}