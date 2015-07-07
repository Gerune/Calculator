using System;
using System.Windows.Forms;
using Calculater.OneArgument;
using Calculater.TwoArguments;

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

        private void Calculator(object sender, EventArgs e)
        {
            double firstArgument = ParsArgument(FirstInput.Text);
            double secondArgument = ParsArgument(SecondInput.Text);
            double result;
            result = TwoArgumentFactory.CreateCalculator(((Button) sender).Name).Calculate(firstArgument, secondArgument);
            Value.Text = Convert.ToString(result);
        }

        void CalculatorSingleArgument(object sender, EventArgs e)
        {
            {
                double firstArgument = ParsArgument(FirstInput.Text);
                double result;
                result = OneArgumentFactory.CreateCalculator(((Button) sender).Name).Calculate(firstArgument);
                Value.Text = Convert.ToString(result);
            }
        }
    }
}
