using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Quotes1 : System.Web.UI.UserControl
    {
        string quote = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            WebRequest webRequest = WebRequest.Create(@"http://iheartquotes.com/api/v1/random?format=text&max_lines=2&max_characters=320&width=225&height=165&show_permalink=false&show_source=false");
            webRequest.Method = "GET";
            HttpWebResponse httpResponse = webRequest.GetResponse() as HttpWebResponse;


            Stream stream = httpResponse.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            quote = streamReader.ReadToEnd();



            LinkButton1.Text = quote;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}