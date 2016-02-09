using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees
{
    public partial class EditEmployee : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeIdString = Request.Params["Id"];
            if (employeeIdString == null)
            {
                Response.Redirect("EmployeesGrid.aspx");
            }

            var employeeId = int.Parse(employeeIdString);

            NorthwindEntities context = new NorthwindEntities();
            var employee = context.Employees
                            .Where(x => x.EmployeeID == employeeId)
                            .Select(x=> new Emp
                            {
                                TitleOfCourtesy = x.TitleOfCourtesy,
                                FirstName = x.FirstName,
                                LastName = x.LastName,
                                Title = x.Title,
                                BirthDate = x.BirthDate,
                                HireDate = x.HireDate,
                                Adress = x.Address,
                                City = x.City,
                                Country = x.Country,
                                Region = x.Region
                            })
                            .ToList();

            this.DetailsViewEmployee.DataSource = employee;
            this.DetailsViewEmployee.DataBind();
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeesGrid.aspx");
        }
    }
}