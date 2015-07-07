using System.ComponentModel;
using System.Windows.Forms;

namespace Calculater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstInput = new System.Windows.Forms.TextBox();
            this.SecondInput = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Summary = new System.Windows.Forms.Button();
            this.TakeAway = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Gradus = new System.Windows.Forms.Button();
            this.DivisionByX = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.PowXY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstInput
            // 
            this.FirstInput.Location = new System.Drawing.Point(23, 13);
            this.FirstInput.Name = "FirstInput";
            this.FirstInput.Size = new System.Drawing.Size(316, 20);
            this.FirstInput.TabIndex = 0;
            // 
            // SecondInput
            // 
            this.SecondInput.Location = new System.Drawing.Point(23, 40);
            this.SecondInput.Name = "SecondInput";
            this.SecondInput.Size = new System.Drawing.Size(316, 20);
            this.SecondInput.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(23, 67);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(316, 20);
            this.Value.TabIndex = 2;
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(23, 93);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(73, 51);
            this.Summary.TabIndex = 15;
            this.Summary.Text = "+";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.Calculator);
            // 
            // TakeAway
            // 
            this.TakeAway.Location = new System.Drawing.Point(102, 93);
            this.TakeAway.Name = "TakeAway";
            this.TakeAway.Size = new System.Drawing.Size(79, 51);
            this.TakeAway.TabIndex = 16;
            this.TakeAway.Text = "-";
            this.TakeAway.UseVisualStyleBackColor = true;
            this.TakeAway.Click += new System.EventHandler(this.Calculator);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(187, 93);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(72, 51);
            this.Multiplication.TabIndex = 17;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculator);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(266, 93);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(73, 51);
            this.Division.TabIndex = 18;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculator);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(23, 146);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(73, 55);
            this.Sin.TabIndex = 19;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(102, 146);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(78, 54);
            this.Abs.TabIndex = 20;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(101, 260);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(78, 53);
            this.Sqrt.TabIndex = 21;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(187, 145);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(72, 55);
            this.Square.TabIndex = 22;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(23, 203);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(73, 55);
            this.Cos.TabIndex = 23;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Gradus
            // 
            this.Gradus.Location = new System.Drawing.Point(102, 203);
            this.Gradus.Name = "Gradus";
            this.Gradus.Size = new System.Drawing.Size(78, 54);
            this.Gradus.TabIndex = 24;
            this.Gradus.Text = "Gradus";
            this.Gradus.UseVisualStyleBackColor = true;
            this.Gradus.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // DivisionByX
            // 
            this.DivisionByX.Location = new System.Drawing.Point(185, 260);
            this.DivisionByX.Name = "DivisionByX";
            this.DivisionByX.Size = new System.Drawing.Size(74, 53);
            this.DivisionByX.TabIndex = 25;
            this.DivisionByX.Text = "1/x";
            this.DivisionByX.UseVisualStyleBackColor = true;
            this.DivisionByX.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(266, 145);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(71, 56);
            this.Percent.TabIndex = 26;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Calculator);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(23, 260);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(73, 53);
            this.Tg.TabIndex = 27;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.CalculatorSingleArgument);
            // 
            // PowXY
            // 
            this.PowXY.Location = new System.Drawing.Point(187, 203);
            this.PowXY.Name = "PowXY";
            this.PowXY.Size = new System.Drawing.Size(72, 52);
            this.PowXY.TabIndex = 28;
            this.PowXY.Text = "x^y";
            this.PowXY.UseVisualStyleBackColor = true;
            this.PowXY.Click += new System.EventHandler(this.Calculator);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 366);
            this.Controls.Add(this.PowXY);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.DivisionByX);
            this.Controls.Add(this.Gradus);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.TakeAway);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.SecondInput);
            this.Controls.Add(this.FirstInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstInput;
        private TextBox SecondInput;
        private TextBox Value;
        private Button Summary;
        private Button TakeAway;
        private Button Multiplication;
        private Button Division;
        private Button Sin;
        private Button Abs;
        private Button Sqrt;
        private Button Square;
        private Button Cos;
        private Button Gradus;
        private Button DivisionByX;
        private Button Percent;
        private Button Tg;
        private Button PowXY;
    }
}

