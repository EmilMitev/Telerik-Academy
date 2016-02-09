using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calc : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;

            double firstNumber;
            double secondnumber;

            switch (but.Text)
            {
                case "1": this.input.Value += but.Text; break;
                case "2": this.input.Value += but.Text; break;
                case "3": this.input.Value += but.Text; break;
                case "4": this.input.Value += but.Text; break;
                case "5": this.input.Value += but.Text; break;
                case "6": this.input.Value += but.Text; break;
                case "7": this.input.Value += but.Text; break;
                case "8": this.input.Value += but.Text; break;
                case "9": this.input.Value += but.Text; break;
                case "+":
                    firstNumber = double.Parse(this.idNumber.Text);
                    secondnumber = double.Parse(this.input.Value);
                    this.idNumber.Text = (firstNumber + secondnumber).ToString();
                    this.input.Value = "";
                    this.idSign.Text = "+";
                    break;
                case "-":
                    firstNumber = double.Parse(this.idNumber.Text);
                    secondnumber = double.Parse(this.input.Value);
                    this.idNumber.Text = (secondnumber - firstNumber).ToString();
                    this.input.Value = "";
                    this.idSign.Text = "-";
                    break;
                case "*":
                    firstNumber = double.Parse(this.idNumber.Text) == 0 ? 1 : double.Parse(this.idNumber.Text);
                    secondnumber = double.Parse(this.input.Value);
                    this.idNumber.Text = (firstNumber * secondnumber).ToString();
                    this.input.Value = "";
                    this.idSign.Text = "*";
                    break;
                case "/":
                    if (this.idNumber.Text == "0")
                    {
                        this.idNumber.Text = this.input.Value;
                        this.input.Value = "";
                        this.idSign.Text = "/";
                    }
                    else
                    {
                        firstNumber = double.Parse(this.idNumber.Text) == 0 ? 1 : double.Parse(this.idNumber.Text);
                        secondnumber = double.Parse(this.input.Value);
                        this.idNumber.Text = (firstNumber / secondnumber).ToString();
                        this.input.Value = "";
                        this.idSign.Text = "/";
                    }
                    break;
                case "=":
                    switch (this.idSign.Text)
                    {
                        case "+":
                            firstNumber = double.Parse(this.idNumber.Text);
                            secondnumber = double.Parse(this.input.Value);
                            this.input.Value = (firstNumber + secondnumber).ToString();
                            this.idSign.Text = "";
                            this.idNumber.Text = "0";
                            break;
                        case "-":
                            firstNumber = double.Parse(this.idNumber.Text);
                            secondnumber = double.Parse(this.input.Value);
                            this.input.Value = (firstNumber - secondnumber).ToString();
                            this.idNumber.Text = "0";
                            this.idSign.Text = "";
                            break;
                        case "*":
                            firstNumber = double.Parse(this.idNumber.Text);
                            secondnumber = double.Parse(this.input.Value);
                            this.input.Value = (firstNumber * secondnumber).ToString();
                            this.idNumber.Text = "0";
                            this.idSign.Text = "";
                            break;
                        case "/":
                            firstNumber = double.Parse(this.idNumber.Text);
                            secondnumber = double.Parse(this.input.Value);
                            this.input.Value = (firstNumber / secondnumber).ToString();
                            this.idNumber.Text = "0";
                            this.idSign.Text = "";
                            break;
                        default:
                            break;
                    }
                    break;
                case "C":
                    this.input.Value = "";
                    this.idNumber.Text = "0";
                    this.idSign.Text = "";
                    break;
                default:
                    this.idNumber.Text = "0";
                    this.input.Value = Math.Sqrt(double.Parse(this.input.Value)).ToString();
                    break;
            }
        }
    }
}