using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21febWeb1
{
    public partial class AboutUS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                name.Text = Session["name"].ToString();
            }
        }
        protected void CheckService(object sender, EventArgs e)
        {
        
        }


        }
    }