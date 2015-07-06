namespace Calculater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Sum = new System.Windows.Forms.Button();
            this.TakeAway = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstInput
            // 
            this.FirstInput.Location = new System.Drawing.Point(23, 13);
            this.FirstInput.Name = "FirstInput";
            this.FirstInput.Size = new System.Drawing.Size(237, 20);
            this.FirstInput.TabIndex = 0;
            // 
            // SecondInput
            // 
            this.SecondInput.Location = new System.Drawing.Point(23, 40);
            this.SecondInput.Name = "SecondInput";
            this.SecondInput.Size = new System.Drawing.Size(237, 20);
            this.SecondInput.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(23, 67);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(237, 20);
            this.Value.TabIndex = 2;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(23, 93);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(73, 51);
            this.Sum.TabIndex = 15;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // TakeAway
            // 
            this.TakeAway.Location = new System.Drawing.Point(102, 93);
            this.TakeAway.Name = "TakeAway";
            this.TakeAway.Size = new System.Drawing.Size(79, 51);
            this.TakeAway.TabIndex = 16;
            this.TakeAway.Text = "-";
            this.TakeAway.UseVisualStyleBackColor = true;
            this.TakeAway.Click += new System.EventHandler(this.TakeAway_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(187, 93);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(73, 51);
            this.Multiplication.TabIndex = 17;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(266, 93);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(73, 51);
            this.Division.TabIndex = 18;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 181);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.TakeAway);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.SecondInput);
            this.Controls.Add(this.FirstInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstInput;
        private System.Windows.Forms.TextBox SecondInput;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button TakeAway;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
    }
}

