using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ADOExample2
{
    class DeptDAL
    {
        public SqlDataReader GetDepartment()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDepartData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return reader;
        }

        public SqlDataReader GetDeptUsingDepno(int depno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
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
            }
            return reader;
        }

        public int InsertDepartment(int depno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
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
            }
            return no;
        }

        public int UpdateDepartment(int depno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
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
            }
            return no;
        }

        public int DeleteDepartment(int depno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
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
            }
            return no;
        }
    }

    class Department
    {
        DeptDAL dal = new DeptDAL();
        public int depno
        {
            get;
            set;
        }

        public string Dname
        {
            get;
            set;
        }

        public string location
        {
            get;
            set;
        }

       
        public void PrintDepartmentData()
        {
            SqlDataReader reader = dal.GetDepartment();
            Console.WriteLine("Depno\tDname\tLocation");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] );
            }
        }

        public void PrintDepartment()
        {
            SqlDataReader reader = dal.GetDeptUsingDepno(depno);
            Console.WriteLine("Depno\tDname\tLocation");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
            }
        }

        public void InsertDepartment()
        {
            int no = dal.InsertDepartment(depno, Dname, location);
            if (no > 0)
            {
                Console.WriteLine("Data Inserted Successfully");
            }
        }

        public void UpdateDepartment()
        {
            int no = dal.UpdateDepartment(depno, Dname, location);
            if (no > 0)
            {
                Console.WriteLine("Data Updated Successfully");
            }
        }

        public void DeleteDepartment()
        {
            int no = dal.DeleteDepartment(depno);
            if (no > 0)
            {
                Console.WriteLine("Data Deleted Successfully");
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Print All Departments");
                Console.WriteLine("2.Print Department based on deptno");
                Console.WriteLine("3.Insert Departments");
                Console.WriteLine("4.Update Departments");
                Console.WriteLine("5.Delete Departments");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Department d = new Department();
                        d.PrintDepartmentData();
                        break;

                    case 2:
                        Department d1 = new Department();
                        Console.WriteLine("Enter department number to view details");
                        d1.depno = Convert.ToInt32(Console.ReadLine());
                        d1.PrintDepartment();
                        break;

                    case 3:
                        Department d2 = new Department();
                        Console.WriteLine("Enter Department Details to Enter Depno,dname,location");
                        d2.depno = Convert.ToInt32(Console.ReadLine());
                        d2.Dname = Console.ReadLine();
                        d2.location = Console.ReadLine();
                        d2.InsertDepartment();
                        break;

                    case 4:
                        Department d3 = new Department();
                        Console.WriteLine("Enter Department Details to Update Depno,dname,location");
                        d3.depno = Convert.ToInt32(Console.ReadLine());
                        d3.Dname = Console.ReadLine();
                        d3.location = Console.ReadLine();
                        d3.UpdateDepartment();
                        break;

                    case 5:
                        Department d4 = new Department();
                        Console.WriteLine("Enter Department no to delete");
                        d4.depno = Convert.ToInt32(Console.ReadLine());
                        d4.DeleteDepartment();
                        break;

                    default:
                        Console.WriteLine("Invalid Case");
                        break;
                }

                Console.WriteLine("Enter y r Y to continue");
                ch = Convert.ToChar(Console.ReadLine());

            }
            while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }
}