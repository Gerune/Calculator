using System;
using System.Windows.Forms;
using Calculater.OneArgument;
using Calculater.SortingOfArrays;
using Calculater.TwoArguments;
using Calculator.Validation;

namespace Calculater
{
    /// <summary>
    /// Functions for calculator and arrays opperations
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function for operations with two numbers
        /// </summary>
        /// <param name="sender">Button, that activated ivent</param>
        /// <param name="e">Operation type</param>
        private void Calculator(object sender, EventArgs e)
        {
            try
            {
                var validator = new Validator();
                double firstArgument = validator.ValidateNumber(FirstInput.Text);
                double secondArgument = validator.ValidateNumber(SecondInput.Text);
                string operationName = (((Button) sender).Name);
                var operation = TwoArgumentFactory.CreateCalculator(operationName);
                double result = operation.Calculate(firstArgument, secondArgument);
                Value.Text = Convert.ToString(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Function for operations with one argument
        /// </summary>
        /// <param name="sender">Button, that activated ivent</param>
        /// <param name="e">Operation type</param>
        private void CalculatorSingleArgument(object sender, EventArgs e)
        {
            try
            {
                {
                    var validator = new Validator();
                    double firstArgument = validator.ValidateNumber(FirstInput.Text);
                    string operationName = (((Button) sender).Name);
                    var operation = OneArgumentFactory.CreateCalculator(operationName);
                    double result = operation.Calculate(firstArgument);
                    Value.Text = Convert.ToString(result);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Function for array sorting
        /// </summary>
        /// <param name="sender">Button, that activated ivent</param>
        /// <param name="e">Operation type</param>
        private void ArraySorting(object sender, EventArgs e)
        {

            try
            {
                var validator = new Validator();
                string[] split = FirstInput.Text.Split(' ');
                double[] array = new double[split.Length];

                for (int i = 0; i < split.Length; i++)
                {
                    array[i] = validator.ValidateNumber(split[i]);
                }

                string operationName = (((Button) sender).Name);
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
