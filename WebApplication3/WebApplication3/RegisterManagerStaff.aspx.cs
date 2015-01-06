using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace WebApplication3
{
    public partial class RegisterManagerStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, email, username, password, confirmpassword, role, encryptedPassword;

            name = txtName.Text;
            email = txtEmail.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            confirmpassword = txtConfirmPassword.Text;
            encryptedPassword = ClassLibrary1.Class1.EncryptPassword(password);

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblErrorMessage.Text += " Password and Confirm password needs to be the same.";
            }

            username = username.ToLower();

            if (DropDownList1.Items[0].Selected)
                role = "Staff";

            else if (DropDownList1.Items[0].Selected)
                role = "Manager";

            else role = "Staff";

          

            string errormessage = GetRegistration(name, username, email, encryptedPassword, role);
            lblErrorMessage.Text = errormessage;

        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
          }

        public string GetRegistration(string name, string username, string emailId, string password, string role)
        {
           
            string fileLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"); // Get path from server root to current
            string path = Path.Combine(fileLocation, "RegisterDB.xml"); // From current to App_Data


            if (File.Exists(path))
            {

                XPathDocument xPathDocument = new XPathDocument(path);

                XPathNavigator xPathNavigator = xPathDocument.CreateNavigator();

                XPathNodeIterator xPathNodeIterator = xPathNavigator.Select("//User");

                int i = 0;

                while (xPathNodeIterator.MoveNext())
                {
                    i++;

                    XPathNodeIterator usernameXml = xPathNodeIterator.Current.Select("UserName");

                    usernameXml.MoveNext();

                    if (username.Equals(usernameXml.Current.InnerXml))
                        return "" + username + " This username already exists.";

                }



                string filepath = Path.Combine(fileLocation, "RegisterDB.xml");

                XmlDocument loginDocument = new XmlDocument();
                loginDocument.Load(filepath);

                XmlNode nodeRegister = loginDocument.CreateNode(XmlNodeType.Element, "Register", null);

                XmlNode nodeName = loginDocument.CreateElement("Name");
                nodeName.InnerText = name;

                XmlNode nodeUsername = loginDocument.CreateElement("UserName");
                nodeUsername.InnerText = username;

                XmlNode nodePassword = loginDocument.CreateElement("Password");
                nodePassword.InnerText = password;

                XmlNode nodeEmailId = loginDocument.CreateElement("EmailId");
                nodeEmailId.InnerText = emailId;

                XmlNode nodeRole = loginDocument.CreateElement("Role");
                nodeRole.InnerText = role;

                nodeRegister.AppendChild(nodeName);
                nodeRegister.AppendChild(nodeUsername);
                nodeRegister.AppendChild(nodePassword);
                nodeRegister.AppendChild(nodeEmailId);
                nodeRegister.AppendChild(nodeRole);

                XmlNode root = loginDocument.DocumentElement;

                root.AppendChild(nodeRegister);

                loginDocument.Save(filepath);

                return "Registration successful";
            }
            else
                return "Error finding XML file";
        }





        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





    }
}