using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Increase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double START_TUITION = 6000;
            const double INCREASE_RATE = 0.02;
            const int YEARS = 5;

            double tuition = START_TUITION;

            tuitionListBox.Items.Clear();

            for (int year = 1; year <= YEARS; year++)
            {
                tuition *= (1 + INCREASE_RATE);

                tuitionListBox.Items.Add(
                    "Year " + year +
                    ": " + tuition.ToString("c")
                );
            }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
