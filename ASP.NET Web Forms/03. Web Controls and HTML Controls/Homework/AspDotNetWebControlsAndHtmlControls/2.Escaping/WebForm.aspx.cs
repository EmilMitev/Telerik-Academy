using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscapingExercise
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonConvert_Click(object sender, EventArgs e)
        {
            var input = this.TextInput.Text;
            this.TextOutput.Text = Server.HtmlEncode(input);
            this.LabelOutput.Text = Server.HtmlEncode(input);
        }
    }
}