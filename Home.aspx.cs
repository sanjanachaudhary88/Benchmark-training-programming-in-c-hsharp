using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtuser.Text == "")
        {
            lblerr.ForeColor = Color.Red;
            lblerr.Text = "Please enter username";

        }
        if (txtpass.Text == "")
        {
            lblerrpass.ForeColor = Color.Red;
            lblerrpass.Text = "Please enter Password";
        }
        else
        {
            string uname = txtuser.Text;
            string pass = txtpass.Text;
            DAL d = new DAL();


            if (d.Login(uname,pass))
            {
                Response.Redirect("Firstform.aspx");
            }
            else
            {
                lblerr2.ForeColor = Color.Red;
                lblerr2.Text = "invalid username or password is entered";
            }



        }
    }
}