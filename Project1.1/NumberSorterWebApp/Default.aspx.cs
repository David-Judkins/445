using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberSorterWebApp
{
    public partial class _Default : Page
    {
        static int flag = -1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        //sets flag to 1 if the user chose ascending order
        protected void Button1_Click1(object sender, EventArgs e)
        {
            SorterPanel.Visible = true;
            flag = 1;
        }

        //sets flag to 1 if the user chose descending order
        protected void Descending_Click(object sender, EventArgs e)
        {
            SorterPanel.Visible = true;
            flag = 2;
        }

        //uses number sorter service 
        protected void Button3_Click(object sender, EventArgs e)
        {
            NumberSorterService.Service1Client stringSort = new NumberSorterService.Service1Client();
            string input = stringSort.InsertionSort(ListInput.Text, flag);
            if (input == null)
            {
                ListPrint.Text = "Hmmm, looks like you need to enter a list of numbers!";
               
                stringSort.Close();
            }
            else
            {
                ListPrint.Text = input;
                ListPrint.ForeColor = System.Drawing.Color.Black;
                stringSort.Close();
            }
        }
    }
}