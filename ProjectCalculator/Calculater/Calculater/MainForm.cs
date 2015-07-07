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
            double result;
            return result = double.Parse(text);
        }
        void Calculator(object sender, EventArgs e)
        {
            double firstArgument = ParsArgument(FirstInput.Text);
            double secondArgument = ParsArgument(SecondInput.Text);
            double result;
            {
                switch (((Button)sender).Name)
                {
                    case "Summary":
                        result = firstArgument + secondArgument;
                        break;
                    case "TakeAway":
                        result = firstArgument - secondArgument;
                        break;
                    case "Multiplication":
                        result = firstArgument * secondArgument;
                        break;
                    case "Division":
                        if (secondArgument == 0.0)
                        {
                            throw new Exception("Division on Zero");
                        }

                        result = firstArgument / secondArgument;
                        break;
                    default: throw new Exception();
                }

                Value.Text = Convert.ToString(result);
            }
        }

        void CalculatorSingleArgument(object sender, EventArgs e)
        {
            {
                double firstArgument = ParsArgument(FirstInput.Text);

                double result;
                switch (((Button)sender).Name)
                {
                    case "Sin":
                        result = Math.Sin(firstArgument);
                        break;

                    case "Abs":
                        result = Math.Abs(firstArgument);
                        break;

                    default:
                        throw new Exception("Unknown operation");
                }

                Value.Text = Convert.ToString(result);
            }
        }
    }
}
