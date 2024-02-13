using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Security.Cryptography;
using System.Text;
using Hash_DLL;
using System.Xml.Linq;
using System.Linq;
using System.Web;

namespace Project3_Tryit
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GymButton(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            string input = serviceClient.FindClosestGyms(GymZip.Text);
            string result = "";

            string[] entries = input.Split(new string[] { "--" }, StringSplitOptions.None);

            foreach (string entry in entries)
            {
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    string[] parts = entry.Split(new char[] { '-' }, StringSplitOptions.None);

                    string name = parts[0];
                    string address = parts[1];

                    result += "Name: " + name;
                    result += "\nAddress: " + address;
                    result += "\n----------------------\n";
                }
            }

            Gym.Text = result;

        }

        protected void LoginButton(object sender, EventArgs e)
        {
            string recaptchaResponse = Request.Form["g-recaptcha-response"];
            string secretKey = "6LcdxAwpAAAAAG0jTFjO_LpvsKEm5nkT4gqx0NfO";
            var client = new WebClient();
            string verificationResult = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={recaptchaResponse}");
            var serializer = new JavaScriptSerializer();
            var reCaptchaVerification = serializer.Deserialize<Dictionary<string, object>>(verificationResult);

            if (Convert.ToBoolean(reCaptchaVerification["success"]))
            {
                result.Text = "Login Success!";
            }
            else
            {
                result.Text = "Login Failure...";
            }
        }

        protected void HashButton(object sender, EventArgs e)
        {
            string hashedPassword = HashingModule.ComputeSha256Hash(hashInput.Text);
            hashOutput.Text = hashedPassword;
        }

        protected void AddMemberButton(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/members.xml");
            XDocument doc = XDocument.Load(filePath);
            var existingMember = doc.Descendants("member").FirstOrDefault(m => (string)m.Element("username") == user);
            if (existingMember != null)
            {
                searchResult.Text = "Member Exists!";
            }
            else
            {
                AddMember(user, pass);
                searchResult.Text = "Member added successfully!";
            }
        }

        protected void SearchButton(object sender, EventArgs e)
        {
            string user = username.Text;

            if(GetMember(user) != null)
            {
                searchResult.Text = "Found Member! User: " + user + " had password: " + GetMember(user).ToString();
            }
        }

        public class Member
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public void AddMember(string username, string password)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/members.xml");
            XDocument doc = XDocument.Load(filePath);

            XElement root = doc.Element("members");
            root.Add(new XElement("member",
                        new XElement("username", username),
                        new XElement("password", password)));

            doc.Save(filePath);
        }


        public string GetMember(string username)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/members.xml");
            XDocument doc = XDocument.Load(filePath);

            var member = doc.Descendants("member")
                            .FirstOrDefault(m => (string)m.Element("username") == username);

            if (member != null)
            {
                return member.Element("password").Value;
            }
            else
            {
                return null;
            }
        }


    }
}