using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCExample3.DAL;
using MVCExample3.Models;
using System.Data.SqlClient;
using System.Data;

namespace MVCExample3.BAL
{
    public class DepartmentBAL
    {
        DepartmentDAL dal=new DepartmentDAL();
        public List<DepartmentModel> GetDepartment()
        {
            SqlDataReader reader = dal.GetDepartment();
            List<DepartmentModel> dlist = new List<DepartmentModel>();
            while (reader.Read())
            {
                DepartmentModel d = new DepartmentModel();
                d.depno = Convert.ToInt32(reader["depno"].ToString());
                d.dname=reader["dname"].ToString();
                d.location = reader["location"].ToString();
                dlist.Add(d);
            }
            return dlist;

        }

        public DepartmentModel GetDeptusingDepno(int depno)
        {
            SqlDataReader reader = dal.GetDeptUsingDepno(depno);
            DepartmentModel d = null;
            while (reader.Read())
            {
                d = new DepartmentModel();
                d.depno = Convert.ToInt32(reader["depno"].ToString());
                d.dname = reader["dname"].ToString();
                d.location = reader["location"].ToString();
               
            }
            return d;

        }
        public int insertDepartment(DepartmentModel d)
        {
            int res= dal.InsertDepartment(d.depno,d.dname,d.location);
            return res;
           

        }

        public int UpdateDepartment(DepartmentModel d)
        {
            int res = dal.UpdateDepartment(d.depno, d.dname, d.location);
            return res;


        }
        //public int UpdateDepartment(DepartmentModel d)
        //{
        //    int res = dal.UpdateDepartment(d.depno, d.dname, d.location);
        //    return res;


        //}
        public int DeleteDepartment(int depno)
        {
            int res = dal.DeleteDepartment(depno);
            return res;
        }
    }
}