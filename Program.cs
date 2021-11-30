
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Disconected_architectureSQL2
{
    class employee
    {
        public SqlDataReader getEmployee()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();



            }
            catch (SqlException ex)

            {
                Console.Write("Exception Occured!!!!" + ex.Message);
            }
            return reader;
        }
        public SqlDataReader Getempusingempid(int empno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("getEmpoyeeUsingEmpno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("empno", empno);
                cmd.Parameters.Add(param);
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.Write("Exception Occured!!!!" + ex.Message);
            }

            return reader;
        }
        public int insertemp(int empno, string ename, string designation, int salary, int depno)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("ename", ename);
                cmd.Parameters.AddWithValue("desig", designation );
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("depno", depno);

                n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return n;
        }
        public int updateemp(int empno, string ename, string designation, int salary, int depno)

        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("ename", ename);
                cmd.Parameters.AddWithValue("desig", designation);
                cmd.Parameters.AddWithValue("salary", salary);
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
        public int deleteemp(int empno)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empno", empno);
                n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return n;
        }
    }


    class employee1
    {
        employee emp = new employee();
        public int empno
        {
            get;
            set;
        }

        public string ename
        {
            get;
            set;
        }

        public string designation
        {
            get;
            set;
        }
        public int salary
        {
            get;
            set;
        }

        

       
        public int depno
        {
            get;
            set;
        }

        public void printdata()
        {
            SqlDataReader reader = emp.getEmployee();
            Console.WriteLine("empno\tename\tdesignation\tsalary\tdepno");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] +
                    "\t" + reader[4] );

            }
        }

        public void printemp()
        {
            SqlDataReader reader = emp.Getempusingempid(empno);
            Console.WriteLine("empno\tename\tdesignation\tsalary\tdepno");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] +
                    "\t" + reader[4] );

            }
        }
        public void insertemp()
        {
            int n = emp.insertemp(empno, ename, designation, salary,  depno);
            if (n > 0)
            {
                Console.WriteLine("Youre Data Inserted Successfully!!!!");
            }
        }
        public void updateemp()
        {
            int n = emp.updateemp(empno, ename, designation, salary, depno); ;
            if (n > 0)
            {
                Console.WriteLine("Youre Data Updated Successfully!!!!");
            }
        }

        public void deleteemp()
        {
            int no = emp.deleteemp(empno);
            if (no > 0)
            {
                Console.WriteLine("Data Deleted Successfully!!!!!");
            }
        }




    }

    class final
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.print all employee details");
                Console.WriteLine("2.print employee details based on employee id");
                Console.WriteLine("3.insert new employee");
                Console.WriteLine("4.update any employee");
                Console.WriteLine("5.delete any employee");
                Console.WriteLine("enter youre choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employee1 e = new employee1();
                        e.printdata();
                        break;

                    case 2:
                        employee1 e1 = new employee1();
                        Console.WriteLine("enter employee id to display employee details");
                        e1.empno = Convert.ToInt32(Console.ReadLine());
                        e1.printemp();
                        break;

                    case 3:
                        employee1 e2 = new employee1();
                        Console.WriteLine("enter following details to insert new employee record");
                        Console.WriteLine("employee id,employee name,designation,salary,department no");
                        e2.empno = Convert.ToInt32(Console.ReadLine());
                        e2.ename = Console.ReadLine();
                        e2.designation = Console.ReadLine();
                        e2.salary = Convert.ToInt32(Console.ReadLine());
                        e2.depno = Convert.ToInt32(Console.ReadLine());
                        e2.insertemp();
                        break;

                    case 4:
                        employee1 e3 = new employee1();
                        Console.WriteLine("enter employee id whose record you want to update");
                        e3.empno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter following details to update");
                        Console.WriteLine("employee name,designation,employee salary,department no");
                        e3.ename = Console.ReadLine();
                        e3.designation = Console.ReadLine();
                        e3.salary = Convert.ToInt32(Console.ReadLine());
                        e3.depno = Convert.ToInt32(Console.ReadLine());
                        e3.updateemp();
                        break;

                    case 5:
                        employee1 e4 = new employee1();
                        Console.WriteLine("enter employee id to delete that employee");
                        e4.empno = Convert.ToInt32(Console.ReadLine());
                        e4.deleteemp();
                        break;

                    default:
                        Console.WriteLine("Invalid case");
                        break;
                }

                Console.WriteLine("Enter Y or y to continue");
                ch = Convert.ToChar(Console.ReadLine());

            }
            while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }

}