using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterForm
{
    public partial class RegisterStudent : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var name = $"<h2>Name: {this.TextBoxFirstName.Text} {this.TextBoxLastName.Text}</h2>";
            var facNumber = $"<h3>Faculty №: {this.TextBoxFacNumber.Text}</h3>";
            var university = $"<h3>Faculty №: {this.DropDownListUniversity.Text}</h3>";
            var specialty = $"<h3>Faculty №: {this.DropDownListSpecialty.Text}</h3>";

            List<ListItem> selected = CheckBoxListCourses.Items
                                                            .Cast<ListItem>()
                                                            .Where(li => li.Selected)
                                                            .ToList();

            var courses = $"<h3>Courses: {string.Join(", ", selected)}</h3>";

            this.form1.Visible = false;
            this.form2.Visible = true;

            Response.Write(name + facNumber + university + specialty + courses);
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            this.form1.Visible = true;
            this.form2.Visible = false;
        }
    }
}