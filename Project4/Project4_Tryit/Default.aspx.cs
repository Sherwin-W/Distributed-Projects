using System;
using System.Collections.Generic;
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
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            Price.Text = serviceClient.GetStockOpen(Ticker.Text, Int32.Parse(Year.Text), Int32.Parse(Month.Text), Int32.Parse(Day.Text));
        }

        protected void SearchButton(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            Address.Text = serviceClient.FindClosestStore(Zipcode.Text, Store.Text);
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

        protected void RecipeButton(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            string input = serviceClient.FindRecipes(Ingredients.Text);
            string[] entries = input.Split(new string[] { "####" }, StringSplitOptions.None);
            List<string> name = new List<string>();
            List<string> image = new List<string>();

            foreach (string entry in entries)
            {
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    string[] parts = entry.Split(new char[] { '#' }, StringSplitOptions.None);

                    name.Add(parts[0]);
                    image.Add(parts[1]);

                }
            }
            first.Text = name[0];
            firstI.ImageUrl = image[0];
            second.Text = name[1];
            secondI.ImageUrl = image[1];
            third.Text = name[2];
            thirdI.ImageUrl = image[2];
            fourth.Text = name[3];
            fourthI.ImageUrl = image[3];
            fifth.Text = name[4];
            fifthI.ImageUrl = image[4];
        }
    }
}