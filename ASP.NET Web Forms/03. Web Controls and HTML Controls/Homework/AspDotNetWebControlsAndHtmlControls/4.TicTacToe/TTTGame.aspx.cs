using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TTTGame : Page
    {
        Random rand;
        private Button[] buttons;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.label.Text = "done!";
            this.buttons = new Button[] {
                this.id1,
                this.id2,
                this.id3,
                this.id4,
                this.id5,
                this.id6,
                this.id7,
                this.id8,
                this.id9
            };

            rand = new Random();
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.Text = "X";

            button.Attributes.Add("disabled", "disabled");

            var winner = CheckIfSomeWon();

            if (winner != "NoOne")
            {
                this.label.Text = $"{winner} won";
            }
            else
            {
                if (buttons.Any(x => x.Attributes["disabled"] == null))
                {
                    ComputerMove();

                    winner = CheckIfSomeWon();

                    if (winner != "NoOne")
                    {
                        this.label.Text = $"{winner} won";
                    }
                }
                else
                {
                    this.label.Text = "draw";
                }
            }
        }

        private void ComputerMove()
        {
            var randomId = rand.Next(0, 9);

            if (buttons[randomId].Attributes["disabled"] == null)
            {
                buttons[randomId].Text = "O";
                buttons[randomId].Attributes.Add("disabled", "disabled");
            }
            else
            {
                ComputerMove();
            }
        }

        private string CheckIfSomeWon()
        {
            if (!string.IsNullOrEmpty(this.id1.Text) && this.id1.Text == this.id2.Text && this.id2.Text == this.id3.Text)
            {
                return this.id1.Text;
            }
            if (!string.IsNullOrEmpty(this.id4.Text) && this.id4.Text == this.id5.Text && this.id5.Text == this.id6.Text)
            {
                return this.id4.Text;
            }
            if (!string.IsNullOrEmpty(this.id7.Text) && this.id7.Text == this.id8.Text && this.id8.Text == this.id9.Text)
            {
                return this.id7.Text;
            }
            if (!string.IsNullOrEmpty(this.id1.Text) && this.id1.Text == this.id4.Text && this.id4.Text == this.id7.Text)
            {
                return this.id1.Text;
            }
            if (!string.IsNullOrEmpty(this.id2.Text) && this.id2.Text == this.id5.Text && this.id5.Text == this.id8.Text)
            {
                return this.id2.Text;
            }
            if (!string.IsNullOrEmpty(this.id3.Text) && this.id3.Text == this.id6.Text && this.id6.Text == this.id9.Text)
            {
                return this.id3.Text;
            }
            if (!string.IsNullOrEmpty(this.id1.Text) && this.id1.Text == this.id5.Text && this.id5.Text == this.id9.Text)
            {
                return this.id1.Text;
            }
            if (!string.IsNullOrEmpty(this.id3.Text) && this.id3.Text == this.id5.Text && this.id5.Text == this.id7.Text)
            {
                return this.id3.Text;
            }

            return "NoOne";
        }
    }
}