using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidJudkinsBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //button listener for the browser go button
        private void btnGo_Click(object sender, EventArgs e)
        {
            txtUrl.Visible = false;
            btnGo.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            button3.Visible = true;
            webBrowser1.Navigate(txtUrl.Text);
        }

        //initiates the encryption when the btn is clicked
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient Client = new EncryptionService.ServiceClient();

            label2.Text = Client.Encrypt(EncryptInput.Text);

            Client.Close();
        }

        //initiates the decryption when the btn is clicked
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient Client = new EncryptionService.ServiceClient();

            label3.Text = Client.Decrypt(label2.Text);

            Client.Close();
        }

        

        

        //allows user to toggle stock quote app when using the browser
        private void button3_Click(object sender, EventArgs e)
        {

            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }


        //allows user to toggle encryption app when using the browser
        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        //returns the price of the simulated quotes when click
        private void button1_Click(object sender, EventArgs e)
        {
            
            StockService.ServiceClient Client = new StockService.ServiceClient();
            string quote1;
            string quote2;
            string quote3;
            bool noInput1 = false;
            bool noInput2 = false;
            bool noInput3 = false;

            //only returns a quote if the user entered sufficient input, otherwise "N/A" is returned
            if (textBox1.Text == "" || textBox1.Text == " ") { quote1 = "N/A"; noInput1 = true; }
            else { quote1 = Client.getStockquote(textBox1.Text); }

            if (textBox3.Text == "" || textBox3.Text == " ") { quote2 = "N/A"; noInput2 = true; }
            else { quote2 = Client.getStockquote(textBox3.Text); }

            if (textBox2.Text == "" || textBox2.Text == " ") {quote3 = "N/A"; noInput3 = true;}
            else { quote3 = Client.getStockquote(textBox2.Text);}

            //on print a "$" when the input is correct
            if (!noInput1) { label9.Text = "$" + quote1; }
            else { label9.Text = quote1; }

            if (!noInput2) { label10.Text = "$" + quote2; }
            else { label10.Text = quote2; }

            if (!noInput3) { label11.Text = "$" + quote3; }
            else { label11.Text = quote3; }

            Client.Close();
            
        }
    }
}
