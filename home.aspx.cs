using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtlogin.Text == "")
        {
            lblerr.Text = "Please enter username";

        }
        if(txtpass.Text == "")
        {
            lblerrpass.Text = "Please enter Password";
        }
        else
        {
            string login=txtlogin.Text;
            string pass=txtpass.Text;
            if(login=="purvesh" && pass == "pass@123")
            {
                Response.Redirect("Firstform.aspx");
            }
            else
            {
                lblerr2.Text = "invalid username or password is entered";
            }
        }
    }
}