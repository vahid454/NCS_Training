using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace _21feb2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getSum(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            sum.Text = (a + b).ToString();
        }

        protected void getVote(object sender, EventArgs e)
        {

           int age=Convert.ToInt32(voter_age.Text);
            if ( age < 18)
            {
                voter_res.Text = "You are not eligible!!";
            }

         
            Thread.Sleep(2000);
            if (age>=18)
            {
           
                //Thread.Sleep(2000);
                Response.Redirect("Voting.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            resCurrentTime.Text = now.ToString();
        }

      
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Age1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            DateTime temp= Calendar1.SelectedDate;

            int age = 0;
            age = DateTime.Now.Subtract(temp).Days;
            age = age / 365;
            
            Age1.Text=age.ToString()+" years.";

        }

        protected void getSalary_Click(object sender, EventArgs e)
        {
            int sumofSal = Convert.ToInt32(basic.Text) + Convert.ToInt32(dear.Text) + Convert.ToInt32(travel.Text);
            int gross = (sumofSal - (2 * (Convert.ToInt32(professional.Text))));

            grossSalary.Text = gross.ToString()+" /- per month";
        }
    }
}