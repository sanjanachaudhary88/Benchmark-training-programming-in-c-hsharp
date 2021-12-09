using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace MVCusingSQLviewAutoGen.DAL
{
    public class DepartmentDAL
    {
        public SqlDataReader GetDepartment()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=RandomDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDepartData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        public SqlDataReader GetDeptUsingDepno(int depno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=RandomDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDeptUsingDepno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("depno", depno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertDepartment(int depno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=RandomDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("depno", depno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);


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

        public int UpdateDepartment(int depno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=RandomDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("depno", depno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);


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

        public int DeleteDepartment(int depno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=RandomDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("depno", depno);
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