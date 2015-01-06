using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            Calendar1.TodaysDate = DateTime.Today;
            Calendar1.SelectedDate = Calendar1.TodaysDate;
        }
    }
}