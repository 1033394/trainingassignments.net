using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q3
{
    public partial class _Default : Page
    {
        protected void validateBtn_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string family = this.family.Text;
            // get other input values

            bool valid = true;

            if (name == family)
            {
                valid = false;
            }

            if (address.MaxLength < 2)
            {
                valid = false;
            }

            // other validations

            if (valid)
            {
                result.Text = "Input is valid";
            }
            else
            {
                result.Text = "Input is NOT valid";
            }
        }
    }
}