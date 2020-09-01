using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSortApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberSortService.Service1Client stringSort = new NumberSortService.Service1Client();
            string input = stringSort.InsertionSort(ListInput.Text);
            StringPrint.Text = input;
            stringSort.Close();
        }
    }
}
