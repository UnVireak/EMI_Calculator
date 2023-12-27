namespace EMICalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            rateTextBox = new TextBox();
            termMumericUpDown = new NumericUpDown();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)termMumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Loan amount (P):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 119);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Annual rate(R)%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 172);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Term(n):";
            label3.Click += label3_Click;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(204, 62);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(195, 27);
            amountTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(205, 112);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(194, 27);
            rateTextBox.TabIndex = 4;
            // 
            // termMumericUpDown
            // 
            termMumericUpDown.Location = new Point(204, 165);
            termMumericUpDown.Name = "termMumericUpDown";
            termMumericUpDown.Size = new Size(195, 27);
            termMumericUpDown.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(464, 76);
            button1.Name = "button1";
            button1.Size = new Size(131, 107);
            button1.TabIndex = 6;
            button1.Text = "Calculate EMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AccessibleName = "outputLabel";
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(768, 87);
            label4.Name = "label4";
            label4.Size = new Size(110, 88);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(311, 232);
            label5.Name = "label5";
            label5.Size = new Size(174, 152);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 520);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(termMumericUpDown);
            Controls.Add(rateTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)termMumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox rateTextBox;
        private NumericUpDown termMumericUpDown;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}