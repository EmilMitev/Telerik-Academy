using System;
using System.Data;
using System.Linq;
using System.Web.UI;

namespace Employees
{
    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Employees> GridViewEmployees_GetData()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Employees.OrderBy(e => e.EmployeeID);
        }
    }
}