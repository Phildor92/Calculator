namespace Calculator.FrontWF
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(12, 12);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(551, 48);
            this.resultTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.oneButton);
            this.flowLayoutPanel1.Controls.Add(this.twoButton);
            this.flowLayoutPanel1.Controls.Add(this.threeButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.fourButton);
            this.flowLayoutPanel1.Controls.Add(this.FiveButton);
            this.flowLayoutPanel1.Controls.Add(this.SixButton);
            this.flowLayoutPanel1.Controls.Add(this.subtractButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.sevenButton);
            this.flowLayoutPanel1.Controls.Add(this.eightButton);
            this.flowLayoutPanel1.Controls.Add(this.nineButton);
            this.flowLayoutPanel1.Controls.Add(this.multiplyButton);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.resetButton);
            this.flowLayoutPanel1.Controls.Add(this.zeroButton);
            this.flowLayoutPanel1.Controls.Add(this.dotButton);
            this.flowLayoutPanel1.Controls.Add(this.divideButton);
            this.flowLayoutPanel1.Controls.Add(this.equalsButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 543);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.Location = new System.Drawing.Point(13, 13);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(125, 125);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoButton.Location = new System.Drawing.Point(144, 13);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(125, 125);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.Location = new System.Drawing.Point(275, 13);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(125, 125);
            this.threeButton.TabIndex = 2;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(406, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 125);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.Location = new System.Drawing.Point(13, 144);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(125, 125);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.Location = new System.Drawing.Point(144, 144);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(125, 125);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.Location = new System.Drawing.Point(275, 144);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(125, 125);
            this.SixButton.TabIndex = 6;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractButton.Location = new System.Drawing.Point(406, 144);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(125, 125);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.Location = new System.Drawing.Point(13, 275);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(125, 125);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.Location = new System.Drawing.Point(144, 275);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(125, 125);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.Location = new System.Drawing.Point(275, 275);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(125, 125);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.Location = new System.Drawing.Point(406, 275);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(125, 125);
            this.multiplyButton.TabIndex = 11;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.Location = new System.Drawing.Point(144, 406);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zeroButton.Size = new System.Drawing.Size(125, 125);
            this.zeroButton.TabIndex = 12;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(13, 406);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 125);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "CE";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalsButton.Location = new System.Drawing.Point(537, 406);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(125, 125);
            this.equalsButton.TabIndex = 14;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideButton.Location = new System.Drawing.Point(406, 406);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(125, 125);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(537, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 125);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(537, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 125);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(537, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 125);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotButton.Location = new System.Drawing.Point(275, 406);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(125, 125);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox resultTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button addButton;
        private Button fourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button subtractButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button multiplyButton;
        private Button zeroButton;
        private Button resetButton;
        private Button equalsButton;
        private Button divideButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button dotButton;
    }
}