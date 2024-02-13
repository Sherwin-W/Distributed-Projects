using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4_Tryit
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void vButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            verif.Text = serviceClient.VerifyXmlWithXsd(XML.Text, XSD.Text);
        }

        protected void sButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            List<string> result = serviceClient.SearchXmlContent(URL.Text, Key.Text).ToList();
            gridViewControl.DataSource = result;
            gridViewControl.DataBind();
        }
    }
}