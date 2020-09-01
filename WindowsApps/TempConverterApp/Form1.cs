using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ConvertF_Click(object sender, EventArgs e)
        {
            TempConverterService.Service1Client tempConverter = new TempConverterService.Service1Client();
            double C = tempConverter.c2f(Convert.ToDouble(numericUpDown2.Value));
            F.Text = C.ToString();
            tempConverter.Close();
        }

        private void ConvertC_Click(object sender, EventArgs e)
        {
            TempConverterService.Service1Client tempConverter = new TempConverterService.Service1Client();
            double F = tempConverter.f2c(Convert.ToDouble(numericUpDown1.Value));
            C.Text = F.ToString();
            tempConverter.Close();
        }
    }
}
