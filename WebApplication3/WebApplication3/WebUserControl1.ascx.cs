using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text +=
                   "Memorial Union. - MU | " + "Hayden Library - HYD |   " + "Nobel Library - NOB |    " + "Sun Devil Book Store - SDBS |    " +
                   "Mathew Center - MC |    " +
                    "Wrigley Hall - WGHL";
        }
    }
}