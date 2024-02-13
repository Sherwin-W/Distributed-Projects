using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toCButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            int celsius = service1Client.F2c(int.Parse(FText.Text));
            CLabel.Text = celsius.ToString() + " C";
        }

        private void toFButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            int fahrenheit = service1Client.C2f(int.Parse(CText.Text));
            FLabel.Text = fahrenheit.ToString() + " F";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            string sortedNums = service1Client.sortNums(inputNums.Text);
            sortedLabel.Text = sortedNums;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = urlBox.Text;
            webBrowser1.Navigate(url);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Int32 result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            symbol.Text = "+";
            equals.Text = result.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Int32 result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            symbol.Text = "-";
            equals.Text = result.ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Int32 result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            symbol.Text = "*";
            equals.Text = result.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            Int32 result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            symbol.Text = "/";
            equals.Text = result.ToString();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            CryptoReference.ServiceClient service1Client = new CryptoReference.ServiceClient();
            encryptResult.Text = service1Client.Encrypt(encryptInput.Text);
            //ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            //encryptResult.Text = service1Client.encrypt(encryptInput.Text);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            CryptoReference.ServiceClient service1Client = new CryptoReference.ServiceClient();
            decryptResult.Text = service1Client.Decrypt(decryptInput.Text);
        }
    }
}
