using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.SessionState;
using System.Web.Security;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String username = TextBox1.Text;
            String password = TextBox2.Text;

            Session["username"] = username;
            string role;

           
             role = GetRole(TextBox1.Text, TextBox2.Text);

            
             if (role != null)
             {

                 FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                   1, // Ticket version
                   username, // Username associated with ticket
                   DateTime.Now, // Date/time issued
                   DateTime.Now.AddMinutes(30), // Date/time to expire
                   true, // "true" for a persistent user cookie
                   role, // User-data, in this case the roles
                   FormsAuthentication.FormsCookiePath);// Path cookie valid for

                 // Encrypt the cookie using the machine key for secure transport
                 string hash = FormsAuthentication.Encrypt(ticket);
                 HttpCookie cookie = new HttpCookie(
                    FormsAuthentication.FormsCookieName, // Name of auth cookie
                    hash); // Hashed ticket

                 // Set the cookie's expiration time to the tickets expiration time
                 if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;

                 // Add the cookie to the list for outgoing response
                 Response.Cookies.Add(cookie);




                 if (role == "Admin")
                 {
                     Response.Redirect("Admin1/RegisterManagerStaff.aspx");
                 }

                 else if (role == "student")
                 {
                     Response.Redirect("Member/MemberPage.aspx");
                 }

                 else if (role == "Manager")
                 {
                     Response.Redirect("Manager/Manager.aspx");
                 }

                 else if (role == "Staff")
                 {

                     Response.Redirect("Staff/Staff.aspx");
                 }

             }

             else Label1.Text = "Sorry! Invalid user!!";
        }


        public string GetRole(string username, string password)
        {
            string Error = ""; ;


            try
            {
                string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
                string file = Path.Combine(fLocation, "RegisterDB.xml");
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(file);
                XmlNodeList nodes = xDoc.GetElementsByTagName("Register");


                bool flag = false;
                foreach (XmlNode node in nodes)
                {
                    if (node["UserName"].InnerText == username)
                    {
                        string pwd = ClassLibrary1.Class1.DecryptPassword(node["Password"].InnerText);
                        flag = true;
                        if (pwd == password)
                        {
                            return node["Role"].InnerText;
                        }
                        else
                            return null;
                    }
                }
                if (flag == false)
                    Error = "User does not exist";
            }
            catch (FileNotFoundException) { return null; }
            catch (Exception) { return null; }
            return null;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage.aspx");
        }




    }
}