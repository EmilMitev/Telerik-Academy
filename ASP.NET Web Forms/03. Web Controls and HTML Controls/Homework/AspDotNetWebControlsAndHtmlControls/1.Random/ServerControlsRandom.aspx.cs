using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandomExercise
{
    public partial class WebServerRandom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            try
            {
                var minValue = int.Parse(this.TextMin.Text);
                var maxValue = int.Parse(this.TextMax.Text);

                this.LabelRandom.Text = rand.Next(minValue, maxValue).ToString();
            }
            catch (FormatException ex)
            {
                this.LabelRandom.Text = "Enter a valid numbers!";
            }
        }
    }
}