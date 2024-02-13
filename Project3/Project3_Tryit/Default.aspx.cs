using System;
using System.Web.UI;

namespace Project3_Tryit
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StockButton(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client serviceClient = new ServiceReference2.Service1Client();
            Price.Text = serviceClient.GetStockOpen(Ticker.Text, Int32.Parse(Year.Text), Int32.Parse(Month.Text), Int32.Parse(Day.Text));
        }

        protected void SearchButton(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            Address.Text = serviceClient.FindClosestStore(Zipcode.Text, Store.Text);
        }
    }
}