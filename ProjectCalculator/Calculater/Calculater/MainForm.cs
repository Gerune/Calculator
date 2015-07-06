using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void TakeAway_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstInput.Text, out firstArgument) &&
               double.TryParse(SecondInput.Text, out secondArgument))
            {
                Value.Text = Convert.ToString(firstArgument - secondArgument);
            }
            else
            {
                Value.Text = "Error";
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstInput.Text, out firstArgument) &&
               double.TryParse(SecondInput.Text, out secondArgument) && secondArgument != 0)
            {
                Value.Text = Convert.ToString(firstArgument / secondArgument);
            }
            else
            {
                Value.Text = "Error";
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstInput.Text, out firstArgument) &&
               double.TryParse(SecondInput.Text, out secondArgument))
            {
                Value.Text = Convert.ToString(firstArgument + secondArgument);
            }
            else
            {
                Value.Text = "Error";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstInput.Text, out firstArgument) &&
               double.TryParse(SecondInput.Text, out secondArgument))
            {
                Value.Text = Convert.ToString(firstArgument * secondArgument);
            }
            else
            {
                Value.Text = "Error";
            }
        }
    }
}
