using System;
using System.Windows.Forms;

namespace Calculater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double ParsArgument(string text)
        {
            double argument;
            double.TryParse(text, out argument);
            return argument;
           
        }
        public void Calculator(object sender, EventArgs e)
        {
            double firstArgument = ParsArgument(FirstInput.Text);
            double secondArgument = ParsArgument(SecondInput.Text);
            {
                switch (((Button)sender).Name)
                {
                    case "Summary":
                        Value.Text = Convert.ToString(firstArgument + secondArgument);
                        break;
                    case "TakeAway":
                        Value.Text = Convert.ToString(firstArgument - secondArgument);
                        break;
                    case "Multiplication":
                        Value.Text = Convert.ToString(firstArgument * secondArgument);
                        break;
                    case "Division":
                        if (secondArgument == 0)
                        {
                            throw new Exception("Division on Zero");
                        }

                        Value.Text = Convert.ToString(firstArgument / secondArgument);
                        break;
                    default: throw new Exception();
                }
            }

        }

        //private void TakeAway_Click(object sender, EventArgs e)
        //{
        //    double firstArgument, secondArgument;
        //    ParsData()
        //    Value.Text = Convert.ToString(firstArgument - secondArgument);
        //}

        //private void Division_Click(object sender, EventArgs e)
        //{
        //    double firstArgument, secondArgument;
        //    if (double.TryParse(FirstInput.Text, out firstArgument) &&
        //       double.TryParse(SecondInput.Text, out secondArgument) && secondArgument != 0)
        //    {
        //        Value.Text = Convert.ToString(firstArgument / secondArgument);
        //    }
        //    else
        //    {
        //        Value.Text = "Error";
        //    }
        //}

        //private void Sum_Click(object sender, EventArgs e)
        //{
        //    double firstArgument, secondArgument;
        //    if (double.TryParse(FirstInput.Text, out firstArgument) &&
        //       double.TryParse(SecondInput.Text, out secondArgument))
        //    {
        //        Value.Text = Convert.ToString(firstArgument + secondArgument);
        //    }
        //    else
        //    {
        //        Value.Text = "Error";
        //    }
        //}

        //private void Multiplication_Click(object sender, EventArgs e)
        //{
        //    double firstArgument, secondArgument;
        //    if (double.TryParse(FirstInput.Text, out firstArgument) &&
        //       double.TryParse(SecondInput.Text, out secondArgument))
        //    {
        //        Value.Text = Convert.ToString(firstArgument * secondArgument);
        //    }
        //    else
        //    {
        //        Value.Text = "Error";
        //    }
    }
}
