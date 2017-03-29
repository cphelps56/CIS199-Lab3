// Colin Phelps
// Lab 3
// 2/10/15
// CIS 199-01
// This program allows for the input of a meal amount and outputs three different tip amounts of 15%, 18%, 20%.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTipBtn_Click(object sender, EventArgs e)
        {
            // Constant fields
            const double TIP_RATE_1 = .15;
            const double TIP_RATE_2 = .18;
            const double TIP_RATE_3 = .2;

            // Variables to hold the first total
            double tipAmount1;

            // Multiply the full price by the first tip rate
            tipAmount1 = int.Parse(inputPriceTextbox.Text) * TIP_RATE_1;

            // Display the total formatted as currency
            tipRate1OutputLabel.Text = tipAmount1.ToString("C");

            // Variable to hold the second total
            double tipAmount2;

            //Multiply the full price by the second tip rate
            tipAmount2 = int.Parse(inputPriceTextbox.Text) * TIP_RATE_2;

            // Display the total formatted as currency
            tipRate2OutputLabel.Text = tipAmount2.ToString("C");

            // Variable to hold the third total
            double tipAmount3;

            // Multiply the full price by the third tip rate
            tipAmount3 = int.Parse(inputPriceTextbox.Text) * TIP_RATE_3;

            //Display the total formatted as currency
            tipRate3OutputLabel.Text = tipAmount3.ToString("C");
        }
    }
}
