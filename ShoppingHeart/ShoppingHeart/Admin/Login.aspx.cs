using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace ShoppingHeart.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            string LoginID = WebConfigurationManager.AppSettings["AdminLoginID"];
            string Password = WebConfigurationManager.AppSettings["AdminPassword"];
            if (txtLoginId.Text == LoginID && txtPassword.Text == Password)
            {
                Session["ShoppingHeartAdmin"] = "ShoppingHeartAdmin";
                Response.Redirect("~Admin/AddNewProducts.aspx");
            }
            else
            {
                lblAlert.Text = "Incorrect LoginID or Password";
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

       
    }
}