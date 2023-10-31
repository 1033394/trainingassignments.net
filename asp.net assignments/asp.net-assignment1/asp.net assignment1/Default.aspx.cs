using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_assignment1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("car1");
                DropDownList1.Items.Add("car2");
                DropDownList1.Items.Add("car3");
                DropDownList1.Items.Add("car4");
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();

            if (selectedItem == "car1")
            {
                Image1.ImageUrl = "car.jpg";
                Label1.Text = "cost: 1lakh";
            }
            else if (selectedItem == "car2")
            {
                Image1.ImageUrl = "car2.jpg";
                Label1.Text = "cost: 2lakh";
            }
            else if (selectedItem == "car3")
            {
                Image1.ImageUrl = "car3.jpg";
                Label1.Text = "cost: 3lakh";
            }
            else if (selectedItem == "car4")
            {
                Image1.ImageUrl = "car4.jpg";
                Label1.Text = "cost: 4lakh";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();
            Label1.Text = "You have chosen " + selectedItem + " and its cost is " + Label1.Text;
        }
    }
}
