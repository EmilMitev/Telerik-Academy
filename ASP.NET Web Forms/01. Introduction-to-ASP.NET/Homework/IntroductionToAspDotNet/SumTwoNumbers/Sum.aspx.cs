using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumTwoNumbers
{
    public partial class Sum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            double numberOne = double.Parse(this.Text1.Value);
            double numberTwo = double.Parse(this.Text2.Value);

            var sum = numberOne + numberTwo;

            this.LabelResult.Text = sum.ToString();

        }
    }
}