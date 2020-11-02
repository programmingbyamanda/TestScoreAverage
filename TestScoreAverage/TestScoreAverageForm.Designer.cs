namespace TestScoreAverage
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outputTest1 = new System.Windows.Forms.Label();
            this.outputTest2 = new System.Windows.Forms.Label();
            this.outputTest3 = new System.Windows.Forms.Label();
            this.outputAverageLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(122, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(571, 160);
            this.listBox1.TabIndex = 0;
            // 
            // outputTest1
            // 
            this.outputTest1.AutoSize = true;
            this.outputTest1.Location = new System.Drawing.Point(265, 69);
            this.outputTest1.Name = "outputTest1";
            this.outputTest1.Size = new System.Drawing.Size(44, 13);
            this.outputTest1.TabIndex = 1;
            this.outputTest1.Text = "Test #1";
            // 
            // outputTest2
            // 
            this.outputTest2.AutoSize = true;
            this.outputTest2.Location = new System.Drawing.Point(265, 108);
            this.outputTest2.Name = "outputTest2";
            this.outputTest2.Size = new System.Drawing.Size(44, 13);
            this.outputTest2.TabIndex = 2;
            this.outputTest2.Text = "Test #2";
            // 
            // outputTest3
            // 
            this.outputTest3.AutoSize = true;
            this.outputTest3.Location = new System.Drawing.Point(269, 137);
            this.outputTest3.Name = "outputTest3";
            this.outputTest3.Size = new System.Drawing.Size(40, 13);
            this.outputTest3.TabIndex = 3;
            this.outputTest3.Text = "test #3";
            // 
            // outputAverageLabel
            // 
            this.outputAverageLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.outputAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputAverageLabel.Location = new System.Drawing.Point(343, 170);
            this.outputAverageLabel.Name = "outputAverageLabel";
            this.outputAverageLabel.Size = new System.Drawing.Size(100, 23);
            this.outputAverageLabel.TabIndex = 4;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(343, 69);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 5;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(343, 108);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 6;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(343, 134);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 7;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(269, 171);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(47, 13);
            this.averageLabel.TabIndex = 8;
            this.averageLabel.Text = "Average";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(211, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 95);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(452, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(452, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.outputAverageLabel);
            this.Controls.Add(this.outputTest3);
            this.Controls.Add(this.outputTest2);
            this.Controls.Add(this.outputTest1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label outputTest1;
        private System.Windows.Forms.Label outputTest2;
        private System.Windows.Forms.Label outputTest3;
        private System.Windows.Forms.Label outputAverageLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

