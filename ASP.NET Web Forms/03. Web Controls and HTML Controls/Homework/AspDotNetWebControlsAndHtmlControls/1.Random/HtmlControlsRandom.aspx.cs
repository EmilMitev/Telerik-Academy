using System;
using System.Web.UI;

namespace RandomExercise
{
    public partial class HtmlControlsRandom : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerate_ServerClick(object sender, EventArgs e)
        {
            Random rand = new Random();
            try
            {
                var minValue = int.Parse(this.TextMin.Value);
                var maxValue = int.Parse(this.TextMax.Value);

                this.LabelRandom.InnerText = rand.Next(minValue, maxValue).ToString();
            }
            catch (FormatException ex)
            {
                this.LabelRandom.InnerText = "Enter a valid numbers!";
            }
        }
    }
}