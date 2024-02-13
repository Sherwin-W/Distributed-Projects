using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            int celsius = serviceClient.F2c(int.Parse(TextBox1.Text));
            CLabel.Text = celsius.ToString() + "C";
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            int fahrenheit = serviceClient.C2f(int.Parse(TextBox2.Text));
            FLabel.Text = fahrenheit.ToString() + "F";
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            string sortedNums = serviceClient.sortNums(TextBox3.Text);
            sortedLabel.Text = sortedNums.ToString();
        }
    }
}