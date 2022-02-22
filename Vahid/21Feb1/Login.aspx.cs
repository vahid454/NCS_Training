using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace _21febWeb1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string email = (EmailID.Text).ToString();
            string a = Session["email"].ToString();
            string password = (Password.Text).ToString();
            string b = Session["password"].ToString();
            if (email.Equals(a))
            {
                if (password.Equals(b))
                {
                    message.Text = "Logging successfully.. redirecting to services.";
                    Thread.Sleep(3000);
                    Response.Redirect("Services.aspx");
                }
                else 
                {
                    message.Text = "Wrong Credentials..";
                }
            }
            else
            {
                message.Text = "Wrong Credentials..";
            }
            Thread.Sleep(2000);
            message.Text = "Wrong Credentials..";
        }
    }
}