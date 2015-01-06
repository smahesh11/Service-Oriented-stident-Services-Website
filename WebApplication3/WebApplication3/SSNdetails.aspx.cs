using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication3
{
    public partial class SSNdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Int32 y = Class1.Encrypt(TextBox1.Text);
            Int32 y1 = Class1.Encrypt(TextBox3.Text);

            Label3.Text = (y.ToString() + '-' + y1.ToString());

            
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Int32 c = Convert.ToInt32(TextBox2.Text);
            Int32 c1 = Convert.ToInt32(TextBox4.Text);
            string y = Class1.Decrypt(c);
            string y1 = Class1.Decrypt(c1);
            Label4.Text = (y.ToString() + y1.ToString());
        
        }
    }
}