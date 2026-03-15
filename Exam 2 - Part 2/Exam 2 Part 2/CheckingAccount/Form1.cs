using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingAccount
{
    public partial class Form1 : Form
    {
        // Account balance
        decimal balance = 0m;

        // Deposit tracking
        int depositCount = 0;
        decimal depositTotal = 0m;

        // Check tracking
        int checkCount = 0;
        decimal checkTotal = 0m;

        // Service charge tracking
        int serviceChargeCount = 0;
        decimal serviceChargeTotal = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // This fixes the designer error
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize balance display
            balanceLabel.Text = balance.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear textbox and radio buttons
            amountTextBox.Clear();
            amountTextBox.Focus();

            depositRadioButton.Checked = false;
            checkRadioButton.Checked = false;
            servicechargeRadioButton.Checked = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            // Validate the textbox input
            if (!decimal.TryParse(amountTextBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid number.");
                amountTextBox.Clear();
                amountTextBox.Focus();
                return;
            }

            // Make sure user selected a transaction
            if (!depositRadioButton.Checked &&
                !checkRadioButton.Checked &&
                !servicechargeRadioButton.Checked)
            {
                MessageBox.Show("Please select a transaction type.");
                return;
            }

            // Process selected transaction
            if (depositRadioButton.Checked)
            {
                ProcessDeposit(amount);
            }
            else if (checkRadioButton.Checked)
            {
                ProcessCheck(amount);
            }
            else if (servicechargeRadioButton.Checked)
            {
                ProcessServiceCharge(amount);
            }

            // Update balance label
            balanceLabel.Text = balance.ToString("c");

            // Reset textbox
            amountTextBox.Clear();
            amountTextBox.Focus();
        }

        // Deposit Method
        private void ProcessDeposit(decimal amount)
        {
            balance += amount;

            depositCount++;
            depositTotal += amount;

            numberDepositLabel.Text = depositCount.ToString();
            depositAmountLabel.Text = depositTotal.ToString("c");
        }

        // Check Method
        private void ProcessCheck(decimal amount)
        {
            if (balance - amount < 0)
            {
                MessageBox.Show("Insufficient Funds");

                // Deduct $10 service charge
                ProcessServiceCharge(10m);
                return;
            }

            balance -= amount;

            checkCount++;
            checkTotal += amount;

            numberChecksLabel.Text = checkCount.ToString();
            checkAmountLabel.Text = checkTotal.ToString("c");
        }

        // Service Charge Method
        private void ProcessServiceCharge(decimal amount)
        {
            balance -= amount;

            serviceChargeCount++;
            serviceChargeTotal += amount;

            numberServiceChargeLabel.Text = serviceChargeCount.ToString();
            serviceChargeAmountLabel.Text = serviceChargeTotal.ToString("c");
        }
    }
}