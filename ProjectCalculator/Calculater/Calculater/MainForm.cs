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

        private void button12_Click(object sender, EventArgs e)
        {
            int firstargument = Convert.ToInt32(FirstInput.Text),
                secondargument = Convert.ToInt32(SecondInput.Text);
            Value.Text = Convert.ToString(firstargument+secondargument);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int firstargument = Convert.ToInt32(FirstInput.Text),
                secondargument = Convert.ToInt32(SecondInput.Text);
            Value.Text = Convert.ToString(firstargument * secondargument);
        }

        private void TakeAway_Click(object sender, EventArgs e)
        {
            int firstargument = Convert.ToInt32(FirstInput.Text),
                secondargument = Convert.ToInt32(SecondInput.Text);
            Value.Text = Convert.ToString(firstargument - secondargument);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            int firstargument = Convert.ToInt32(FirstInput.Text),
                secondargument = Convert.ToInt32(SecondInput.Text);
            Value.Text = Convert.ToString(firstargument / secondargument);
        }
    }
}
