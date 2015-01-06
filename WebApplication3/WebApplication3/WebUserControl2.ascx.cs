using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String semester, year;
            Int32 m = DateTime.Now.Month;
            string course1;
            string course2;

            if (m <= 5)
            {
                semester = "Spring";
                course1 = "IAS";
                course2 = "IR";
            }
            else if (m <= 7)
            {
                semester = "Summer";
                course1 = "DMOS";
                course2 = "DMOS";
            }
            else
            {
                semester = "Fall";
                course1 = "DSOD";
                course2 = "SS";

            }
            Int32 yr = DateTime.Now.Year;
            year = yr.ToString();
            lblSemester.Text = semester;
            lblYear.Text = year;
            LblCourse1.Text = course1;
            LblCourse2.Text = course2;
        }
    }
}