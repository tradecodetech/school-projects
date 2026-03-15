
namespace CheckingAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servicechargeRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceChargeAmountLabel = new System.Windows.Forms.Label();
            this.numberServiceChargeLabel = new System.Windows.Forms.Label();
            this.checkAmountLabel = new System.Windows.Forms.Label();
            this.numberChecksLabel = new System.Windows.Forms.Label();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.numberDepositLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.Yellow;
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(160, 53);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(208, 30);
            this.amountTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.servicechargeRadioButton);
            this.groupBox1.Controls.Add(this.checkRadioButton);
            this.groupBox1.Controls.Add(this.depositRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(223, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type";
            // 
            // servicechargeRadioButton
            // 
            this.servicechargeRadioButton.AutoSize = true;
            this.servicechargeRadioButton.Location = new System.Drawing.Point(21, 105);
            this.servicechargeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.servicechargeRadioButton.Name = "servicechargeRadioButton";
            this.servicechargeRadioButton.Size = new System.Drawing.Size(169, 29);
            this.servicechargeRadioButton.TabIndex = 4;
            this.servicechargeRadioButton.TabStop = true;
            this.servicechargeRadioButton.Text = "&Service Charge";
            this.servicechargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(21, 68);
            this.checkRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(90, 29);
            this.checkRadioButton.TabIndex = 3;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "C&heck";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Location = new System.Drawing.Point(21, 31);
            this.depositRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(99, 29);
            this.depositRadioButton.TabIndex = 2;
            this.depositRadioButton.TabStop = true;
            this.depositRadioButton.Text = "&Deposit";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Balance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.Color.Yellow;
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(217, 31);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(185, 34);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(267, 110);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 49);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(267, 167);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(157, 49);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(267, 224);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 49);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Deposits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Checks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Service Charges:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Deposit Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Check Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Service Charge Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceChargeAmountLabel);
            this.groupBox2.Controls.Add(this.numberServiceChargeLabel);
            this.groupBox2.Controls.Add(this.checkAmountLabel);
            this.groupBox2.Controls.Add(this.numberChecksLabel);
            this.groupBox2.Controls.Add(this.depositAmountLabel);
            this.groupBox2.Controls.Add(this.numberDepositLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.balanceLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 375);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary of Transactions";
            // 
            // serviceChargeAmountLabel
            // 
            this.serviceChargeAmountLabel.BackColor = System.Drawing.Color.Yellow;
            this.serviceChargeAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceChargeAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceChargeAmountLabel.Location = new System.Drawing.Point(300, 329);
            this.serviceChargeAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceChargeAmountLabel.Name = "serviceChargeAmountLabel";
            this.serviceChargeAmountLabel.Size = new System.Drawing.Size(185, 34);
            this.serviceChargeAmountLabel.TabIndex = 19;
            this.serviceChargeAmountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numberServiceChargeLabel
            // 
            this.numberServiceChargeLabel.BackColor = System.Drawing.Color.Yellow;
            this.numberServiceChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberServiceChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberServiceChargeLabel.Location = new System.Drawing.Point(300, 282);
            this.numberServiceChargeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberServiceChargeLabel.Name = "numberServiceChargeLabel";
            this.numberServiceChargeLabel.Size = new System.Drawing.Size(185, 34);
            this.numberServiceChargeLabel.TabIndex = 18;
            this.numberServiceChargeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // checkAmountLabel
            // 
            this.checkAmountLabel.BackColor = System.Drawing.Color.Yellow;
            this.checkAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAmountLabel.Location = new System.Drawing.Point(216, 234);
            this.checkAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkAmountLabel.Name = "checkAmountLabel";
            this.checkAmountLabel.Size = new System.Drawing.Size(185, 34);
            this.checkAmountLabel.TabIndex = 17;
            this.checkAmountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numberChecksLabel
            // 
            this.numberChecksLabel.BackColor = System.Drawing.Color.Yellow;
            this.numberChecksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberChecksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberChecksLabel.Location = new System.Drawing.Point(216, 190);
            this.numberChecksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberChecksLabel.Name = "numberChecksLabel";
            this.numberChecksLabel.Size = new System.Drawing.Size(185, 34);
            this.numberChecksLabel.TabIndex = 16;
            this.numberChecksLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.BackColor = System.Drawing.Color.Yellow;
            this.depositAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountLabel.Location = new System.Drawing.Point(216, 140);
            this.depositAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(185, 34);
            this.depositAmountLabel.TabIndex = 15;
            this.depositAmountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numberDepositLabel
            // 
            this.numberDepositLabel.BackColor = System.Drawing.Color.Yellow;
            this.numberDepositLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberDepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDepositLabel.Location = new System.Drawing.Point(216, 98);
            this.numberDepositLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberDepositLabel.Name = "numberDepositLabel";
            this.numberDepositLabel.Size = new System.Drawing.Size(185, 34);
            this.numberDepositLabel.TabIndex = 14;
            this.numberDepositLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Checking Account Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 678);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Checking Account ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton servicechargeRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.RadioButton depositRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serviceChargeAmountLabel;
        private System.Windows.Forms.Label numberServiceChargeLabel;
        private System.Windows.Forms.Label checkAmountLabel;
        private System.Windows.Forms.Label numberChecksLabel;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.Label numberDepositLabel;
        private System.Windows.Forms.Label label9;
    }
}

