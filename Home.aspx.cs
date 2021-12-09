using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["nohits"] == null)
        {
            Application["nohits"] = 1;
        }
        else
        {
            int i;
            i = Convert.ToInt32(Application["nohits"]);
            i++;
            Application["nohits"] = i;
        }
        LblForHits.Text = "No Of Hits Are: " + Application["nohits"].ToString();



        if (TextUser.Text == "")
        {
            LblErrUser.Text = "Please Enter user Name";
        }
        else if (TextPass.Text == "")
        {
            LblErrPass.Text = "Please Enter Password";

        }
        else
        {
            DAL d = new DAL();
            string username = TextUser.Text;
            string password = TextPass.Text;
            if (d.Login(username, password))
            {

                Response.Redirect("Welcome.aspx");
            }
            else
            {
                LblErr.Text = "Invalid Username and Password";
            }

        }

    }
}