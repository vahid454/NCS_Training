using System;
using System.Threading;
using System.Text.RegularExpressions;
namespace WebFormsControlls
{
    public partial class WebControls : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["name"] = username.Text;
            Session["email"] = EmailID.Text;
            string pwd1 = (TextBox2.Text).ToString();
            string pwd2 = (TextBox3.Text).ToString();
            if (pwd1 != pwd2)
            {
                message.Text = "Password does not match!!";
                return;
            }
            message.Text = "";
            Session["password"] = TextBox2.Text;

            if (RadioButton1.Checked)
            {
                Session["gender"] = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                Session["gender"] = RadioButton2.Text;

            }
            else 
            {
                message.Text = "Please choose gender!!";
                return;
            }
            string city = (DropDownList1.SelectedValue).ToString();
            string phone = (TextBox4.Text).ToString();
            if (city==null)
            {
                message.Text = "Please choose city!!";
                return;
            }
            Session["city"] = city;
            Regex re = new Regex("^9[0-9]{9}");

            if (re.IsMatch(phone.Trim()) == false || TextBox4.Text.Length > 10)

            {

                message.Text = "Invalid Mobile Number !!";

                TextBox4.Focus();
                return;
            }
            Session["phone"] = phone;
            message.Text = "Registration successfully.. redirecting to login.";
            Thread.Sleep(3000);
            Response.Redirect("Login.aspx");
     
     
    }

        
    }
}