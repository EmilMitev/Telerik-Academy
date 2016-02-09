using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars
{
    public partial class SearchCar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var producers = DataBase.cars.Select(x => x.Name);
                this.DropDownListProducer.DataSource = producers;
                this.DropDownListProducer.DataBind();
            }
        }

        protected void DropDownListProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProducer = this.DropDownListProducer.SelectedValue;
            var producerModels = DataBase.cars
                                            .Where(x => x.Name == selectedProducer)
                                            .FirstOrDefault()
                                            .Models
                                            .Select(x => x.Name)
                                            .ToList();

            var modelsEngine = Enum.GetNames(typeof(EnumEngine)).ToList();
            var modelsExtra = Enum.GetNames(typeof(EnumExtra)).ToList();

            this.RadioButtonListTypeOfEngine.DataSource = modelsEngine;
            this.RadioButtonListTypeOfEngine.DataBind();

            this.CheckBoxListSetOfExtras.DataSource = modelsExtra;
            this.CheckBoxListSetOfExtras.DataBind();

            this.DropDownListModel.DataSource = producerModels;
            this.DropDownListModel.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            var producer = this.DropDownListProducer.Text;
            var model = this.DropDownListModel.Text;
            var engineType = this.RadioButtonListTypeOfEngine.Text;
            var selectedExtra = this.CheckBoxListSetOfExtras.Items
                                                        .Cast<ListItem>()
                                                        .Where(li => li.Selected)
                                                        .ToList();

            var extra = string.Join(", ", selectedExtra);

            this.LiteralResult.Text = $@"Producer: {producer}, 
                                         model: {model}, 
                                         engine type:{engineType}, 
                                         extra: {extra}";
        }
    }
}