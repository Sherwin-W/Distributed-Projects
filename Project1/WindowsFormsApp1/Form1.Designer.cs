namespace WindowsFormsApp1
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
            this.toCButton = new System.Windows.Forms.Button();
            this.toFButton = new System.Windows.Forms.Button();
            this.FText = new System.Windows.Forms.TextBox();
            this.CText = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.FLabel = new System.Windows.Forms.Label();
            this.inputNums = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.symbol = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptResult = new System.Windows.Forms.Label();
            this.decryptResult = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptInput = new System.Windows.Forms.TextBox();
            this.decryptInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toCButton
            // 
            this.toCButton.Location = new System.Drawing.Point(111, 12);
            this.toCButton.Name = "toCButton";
            this.toCButton.Size = new System.Drawing.Size(89, 23);
            this.toCButton.TabIndex = 0;
            this.toCButton.Text = "To Celsius";
            this.toCButton.UseVisualStyleBackColor = true;
            this.toCButton.Click += new System.EventHandler(this.toCButton_Click);
            // 
            // toFButton
            // 
            this.toFButton.Location = new System.Drawing.Point(111, 40);
            this.toFButton.Name = "toFButton";
            this.toFButton.Size = new System.Drawing.Size(89, 23);
            this.toFButton.TabIndex = 1;
            this.toFButton.Text = "To Fahrenheit";
            this.toFButton.UseVisualStyleBackColor = true;
            this.toFButton.Click += new System.EventHandler(this.toFButton_Click);
            // 
            // FText
            // 
            this.FText.Location = new System.Drawing.Point(49, 14);
            this.FText.Name = "FText";
            this.FText.Size = new System.Drawing.Size(56, 20);
            this.FText.TabIndex = 2;
            // 
            // CText
            // 
            this.CText.Location = new System.Drawing.Point(49, 43);
            this.CText.Name = "CText";
            this.CText.Size = new System.Drawing.Size(56, 20);
            this.CText.TabIndex = 3;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(206, 17);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(29, 13);
            this.CLabel.TabIndex = 5;
            this.CLabel.Text = "---- C";
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(206, 46);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(28, 13);
            this.FLabel.TabIndex = 6;
            this.FLabel.Text = "---- F";
            // 
            // inputNums
            // 
            this.inputNums.Location = new System.Drawing.Point(104, 88);
            this.inputNums.Name = "inputNums";
            this.inputNums.Size = new System.Drawing.Size(100, 20);
            this.inputNums.TabIndex = 7;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(209, 86);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(80, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort Numbers";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Location = new System.Drawing.Point(295, 91);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(28, 13);
            this.sortedLabel.TabIndex = 9;
            this.sortedLabel.Text = "-------";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 153);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(753, 426);
            this.webBrowser1.TabIndex = 10;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(80, 127);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(100, 20);
            this.urlBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Nums List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 498);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Location = new System.Drawing.Point(136, 502);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(19, 13);
            this.symbol.TabIndex = 19;
            this.symbol.Text = "__";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(30, 536);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(39, 23);
            this.add.TabIndex = 20;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(91, 536);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 23);
            this.minus.TabIndex = 21;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(161, 536);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(39, 23);
            this.mult.TabIndex = 22;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(222, 536);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(39, 23);
            this.div.TabIndex = 23;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(276, 502);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(28, 13);
            this.equals.TabIndex = 24;
            this.equals.Text = "= __";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Calculator";
            // 
            // encryptResult
            // 
            this.encryptResult.AutoSize = true;
            this.encryptResult.Location = new System.Drawing.Point(559, 473);
            this.encryptResult.Name = "encryptResult";
            this.encryptResult.Size = new System.Drawing.Size(19, 13);
            this.encryptResult.TabIndex = 28;
            this.encryptResult.Text = "----";
            // 
            // decryptResult
            // 
            this.decryptResult.AutoSize = true;
            this.decryptResult.Location = new System.Drawing.Point(559, 522);
            this.decryptResult.Name = "decryptResult";
            this.decryptResult.Size = new System.Drawing.Size(19, 13);
            this.decryptResult.TabIndex = 29;
            this.decryptResult.Text = "----";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(478, 468);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 30;
            this.encryptButton.Text = "Encrypt!";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(478, 517);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 31;
            this.decryptButton.Text = "Decrypt!";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptInput
            // 
            this.encryptInput.Location = new System.Drawing.Point(372, 470);
            this.encryptInput.Name = "encryptInput";
            this.encryptInput.Size = new System.Drawing.Size(100, 20);
            this.encryptInput.TabIndex = 32;
            // 
            // decryptInput
            // 
            this.decryptInput.Location = new System.Drawing.Point(372, 517);
            this.decryptInput.Name = "decryptInput";
            this.decryptInput.Size = new System.Drawing.Size(100, 20);
            this.decryptInput.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 591);
            this.Controls.Add(this.decryptInput);
            this.Controls.Add(this.encryptInput);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptResult);
            this.Controls.Add(this.encryptResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.inputNums);
            this.Controls.Add(this.FLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.CText);
            this.Controls.Add(this.FText);
            this.Controls.Add(this.toFButton);
            this.Controls.Add(this.toCButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toCButton;
        private System.Windows.Forms.Button toFButton;
        private System.Windows.Forms.TextBox FText;
        private System.Windows.Forms.TextBox CText;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.TextBox inputNums;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label sortedLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label encryptResult;
        private System.Windows.Forms.Label decryptResult;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox encryptInput;
        private System.Windows.Forms.TextBox decryptInput;
    }
}

