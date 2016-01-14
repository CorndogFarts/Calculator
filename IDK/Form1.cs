using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDK
{
    public partial class Form1 : Form
    {

        private Operands operand;
        private string num1;
        private const string CharPlus = "+";
        private const string CharMinus = "-";
        private const string CharMult = "*";
        private const string CharDiv = "/";

        public Form1()
        {
            InitializeComponent();

        }

		// this makes sure that everything is clear when the program is started and that the 
		// operator keys can be pressed as well as the actual buttons on the application
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "&" + CharPlus;
            btnSub.Text = "&" + CharMinus;
            btnMult.Text = "&" + CharMult;
            btnDiv.Text = "&" + CharDiv;
            label1.Text = "";
            txtConsole.Text = "0";
            btnEnter.Focus();
        }

		// enum Operands is a new type of variable to be used in the btnEnter and btnOperator click events
        public enum Operands
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }


		// Takes the text of the button pressed, and prints it into the textbox
        private void num_Click(object sender, EventArgs e)
        {
            if (txtConsole.Text == "0")
            {
                txtConsole.Clear();
            }
            txtConsole.Text += ((Button) sender).Text.Replace("&", "").Replace("(", "").Replace(")", "");
            btnEnter.Focus();
        }

		// When an operator is clicked, it sends what is in the textbox into the num1 
		// variable and sends it to the label above the textbox along with the operator that was clicked
        private void btnOperator_Click(object sender, EventArgs e)
        {

            num1 = txtConsole.Text;
            txtConsole.Text = "";

            switch (((Button) sender).Name)
            {
                case "btnAdd":
                    this.operand = Operands.Add;
                    label1.Text = num1 + CharPlus;
                    break;
                case "btnSub":
                    this.operand = Operands.Subtract;
                    label1.Text = num1 + CharMinus;
                    break;
                case "btnMult":
                    this.operand = Operands.Multiply;
                    label1.Text = num1 + CharMult;
                    break;
                case "btnDiv":
                    this.operand = Operands.Divide;
                    label1.Text = num1 + CharDiv;
                    break;
            }
            btnEnter.Focus();
        }

		// Checks what operator is to be used, and executes the equation according to the operator
        private void btnEnter_Click(object sender, EventArgs e)
        {
            float fnum1 = Convert.ToSingle(num1);
            float fnum2 = Convert.ToSingle(txtConsole.Text);

            switch (this.operand)
            {
                case Operands.Add:
                    txtConsole.Text = Convert.ToString(fnum1 + fnum2);
                    break;
                case Operands.Subtract:
                    txtConsole.Text = Convert.ToString(fnum1 - fnum2);
                    break;
                case Operands.Multiply:
                    txtConsole.Text = Convert.ToString(fnum1*fnum2);
                    break;
                case Operands.Divide:
                    txtConsole.Text = Convert.ToString(fnum1/fnum2);
                    break;
            }
            btnEnter.Focus();
        }

		// clear button, sets all textboxes and variables to "0"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "0";
            label1.Text = "";
            num1 = "0";
            btnEnter.Focus();

        }

		// backspace button, removes one character from end of textbox 
		// sets it to 0 if there is nothing left to remove
        private void btnBack_Click(object sender, EventArgs e)
        {
            var length = txtConsole.Text.Length;
            txtConsole.Text = txtConsole.Text.Remove(length - 1, 1);
            if (this.txtConsole.Text == "")
            {
                txtConsole.Text = "0";
            }
            btnEnter.Focus();
        }

		// closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




