using System;
using System.Windows.Forms;
using Calculater.OneArgument;
using Calculater.SortingOfMassives;
using Calculater.TwoArguments;

namespace Calculater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private double ParsArgument(string text)
        {
            return double.Parse(text);
        }

        private void Calculator(object sender, EventArgs e)
        {
            double firstArgument = ParsArgument(FirstInput.Text);
            double secondArgument = ParsArgument(SecondInput.Text);
            string operationName = (((Button)sender).Name);
            var operation = TwoArgumentFactory.CreateCalculator(operationName);
            double result = operation.Calculate(firstArgument, secondArgument);
            Value.Text = Convert.ToString(result);
        }

        private void CalculatorSingleArgument(object sender, EventArgs e)
        {
            {
                double firstArgument = ParsArgument(FirstInput.Text);
                string operationName = (((Button)sender).Name);
                var operation = OneArgumentFactory.CreateCalculator(operationName);
                double result = operation.Calculate(firstArgument);
                Value.Text = Convert.ToString(result);
            }
        }

        private void ArraySorting(object sender, EventArgs e)
        {
            string[] split = FirstInput.Text.Split(' ');
            double[] array = new double[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                array[i] = ParsArgument(split[i]);
            }

            string operationName = (((Button)sender).Name);
            var operation = ArraySortingFactory.CreateSorting(operationName);
            double[] resultDoubleArray = operation.Sort(array);

            string[] resultStringArray = new string[split.Length];

            for (int i = 0; i < array.Length; i++)
            {
                resultStringArray[i] = Convert.ToString(resultDoubleArray[i]);
            }

            string resultString = "";

            for (int i = 0; i < resultStringArray.Length; i++)
            {
                resultString += resultStringArray[i] + ' ';
            }

            Value.Text = resultString;

        }
    }
}
