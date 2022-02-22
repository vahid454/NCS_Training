using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
namespace _21feb2
{
    public partial class Voting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getVote(object sender, EventArgs e)
        {
            vote_res.Text = " Congrats !! Done";

            Thread.Sleep(2000);
            Response.Redirect("WebForm1.aspx");
        }
    }
}