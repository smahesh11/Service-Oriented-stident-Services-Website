using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Global_ASAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             string userName = TextBox1.Text;
        string passWord = TextBox2.Text;

        string sKey = TextBox1.Text;
        string sUser = Convert.ToString(Cache[sKey]);
        if (sUser == null || sUser == String.Empty)
        {
            TimeSpan SessTimeOut = new TimeSpan(0, 0, HttpContext.Current.Session.Timeout, 0, 0);
            HttpContext.Current.Cache.Insert(sKey, sKey, null, DateTime.MaxValue, SessTimeOut, System.Web.Caching.CacheItemPriority.NotRemovable, null);
            Session["user"] = TextBox1.Text.Trim();

            if (userName.Equals("1207250300") && passWord.Equals("password"))
            {
                Response.Write("Welcome " + userName);
            }
            else
            {
                Response.Write("Invalid Login");
            }
        }
        else
        {
            Response.Write("<Marquee><h1><font color=red>ILLEGAL LOGIN ATTEMPT!!!</font></h1></marquee>");
            return;
        }
    }
        }
    }
