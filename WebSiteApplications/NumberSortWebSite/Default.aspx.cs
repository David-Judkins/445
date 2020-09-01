using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberSortWebSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NumberSortService.Service1Client stringSort = new NumberSortService.Service1Client();
            string input = stringSort.InsertionSort(ListInput.Text);
            if (input == null)
            {
                ListPrint.Text = "Hmmm, looks like you need to enter a list!";
                ListPrint.ForeColor = System.Drawing.Color.Black;
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