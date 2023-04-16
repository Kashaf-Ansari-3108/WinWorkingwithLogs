using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGeorgetownCleaningService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateSubtotal(TextBox priceTextBox, TextBox qtyTextBox, TextBox totalTextBox)
        {
            decimal unitPrice = 0;
            decimal qty = 0;
            decimal subTotal = 0;

            // Parse the unit price and quantity text as decimal values
            decimal.TryParse(priceTextBox.Text, out unitPrice);
            decimal.TryParse(qtyTextBox.Text, out qty);

            // Calculate the subtotal
            subTotal = unitPrice * qty;

            // Update the total textbox
            totalTextBox.Text = subTotal.ToString("F2");
        }


        private void txtshirtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtShirtPrice, txtShirtQty, txtShirtTotal);

        }

        private void txtShirtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtShirtPrice, txtShirtQty, txtShirtTotal);
        }

        private void txtPantPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtPantPrice, txtPantQty, txtPantTotal);
        }

        private void txtPantQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtPantPrice, txtPantQty, txtPantTotal);
        }

        private void txtSuitsPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtSuitsPrice, txtSuitsQty, txtSuitsTotal);
        }

        private void txtSuitsQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtSuitsPrice, txtSuitsQty, txtSuitsTotal);
        }

        private void txtOWPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtOWPrice, txtOWQty, txtOWTotal);
        }

        private void txtOWQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtOWPrice, txtOWQty, txtOWTotal);
        }

        private void txtSWPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtSWPrice, txtSWQty, txtSWTotal);
        }

        private void txtSWQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtSWPrice, txtSWQty, txtSWTotal);
        }

        private void txtFWPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtFWPrice, txtFWQty, txtFWTotal);
        }

        private void txtFWQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal(txtFWPrice, txtFWQty, txtFWTotal);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate the subtotal for all items
            decimal subtotal = 0;
            decimal.TryParse(txtShirtTotal.Text, out decimal shirtTotal);
            decimal.TryParse(txtPantTotal.Text, out decimal pantTotal);
            decimal.TryParse(txtSuitsTotal.Text, out decimal suitsTotal);
            decimal.TryParse(txtOWTotal.Text, out decimal owTotal);
            decimal.TryParse(txtSWTotal.Text, out decimal swTotal);
            decimal.TryParse(txtFWTotal.Text, out decimal fwTotal);

            subtotal = shirtTotal + pantTotal + suitsTotal + owTotal + swTotal + fwTotal;
            txtCleaningTotal.Text = subtotal.ToString("F2");

            // Calculate the tax based on the rate in the tax rate textbox
            decimal taxRate = 0;
            decimal.TryParse(txtTaxRate.Text, out taxRate);
            decimal taxAmount = (subtotal * taxRate) / 100;
            txtTaxAmount.Text = taxAmount.ToString("F2");

            // Calculate the total and display it in the net price textbox
            decimal total = subtotal + taxAmount;
            txtNetPrice.Text = total.ToString("F2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string fileName = "E:\\FUUAST\\Semester 5\\Visual Programming\\Cleaning Service Screen\\DataFiles\\" + txtCustName.Text.ToString().Replace(" ", "") + ".txt";

            // Check if the file already exists
            if (File.Exists(fileName))
            {
                // Append a unique identifier to the file name
                fileName = "E:\\FUUAST\\Semester 5\\Visual Programming\\Cleaning Service Screen\\DataFiles\\" + txtCustName.Text.ToString().Replace(" ", "")+"_"+Services.Guid() + ".txt";
            }

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine("------------------------------------------");
            sw.WriteLine("Log Date: " + DateTime.Now.ToString());
            sw.WriteLine("------------------------------------------");
            sw.WriteLine("ORDER IDENTIFICATION");
            sw.WriteLine("Customer Name: " + txtCustName.Text);
            sw.WriteLine("Customer Phone: " + txtCustPhone.Text);
            sw.WriteLine("Date and Time When Left: " + dateLeft.Text + " " + timeLeft.Text);
            sw.WriteLine("Expected Date and Time to complete: " + dateExpected.Text + " " + timeExpected.Text);
            sw.WriteLine("------------------------------------------");
            sw.WriteLine("ORDER PROCESSING");
            sw.WriteLine("Shirt => qty: " + txtShirtQty.Text + " unit price: " + txtShirtPrice.Text + " Total: " + txtShirtTotal.Text);
            sw.WriteLine("Pant => qty: " + txtPantQty.Text + " unit price: " + txtPantPrice.Text + " Total: " + txtPantTotal.Text);
            sw.WriteLine(cmbSuits.Text + " => qty: " + txtSuitsQty.Text + " unit price: " + txtSuitsPrice.Text + " Total: " + txtSuitsTotal.Text);
            sw.WriteLine(cmbOuterWear.Text + " => qty: " + txtOWQty.Text + " unit price: " + txtOWPrice.Text + " Total: " + txtOWTotal.Text);
            sw.WriteLine(cmbSportsWear.Text + " => qty: " + txtSWQty.Text + " unit price: " + txtSWPrice.Text + " Total: " + txtSWTotal.Text);
            sw.WriteLine(cmbFormalWear.Text + " => qty: " + txtFWQty.Text + " unit price: " + txtFWPrice.Text + " Total: " + txtFWTotal.Text);
            sw.WriteLine("------------------------------------------");
            sw.WriteLine("ORDER SUMMARY");
            sw.WriteLine("Cleaning Total: " + txtCleaningTotal.Text);
            sw.WriteLine("Tax Rate: " + txtTaxRate.Text);
            sw.WriteLine("Tax Amount: " + txtTaxAmount.Text);
            sw.WriteLine("Net Price: " + txtNetPrice.Text);
            sw.WriteLine("------------------------------------------");
            sw.Close();

            txtCustName.Text = "";
            txtCustPhone.Text = "";
            dateLeft.Text = "";
            timeLeft.Text = "";
            dateExpected.Text = "";
            timeExpected.Text = "";
            txtShirtQty.Text = "0";
            txtShirtPrice.Text = "0.00";
            txtShirtTotal.Text = "0.00";
            txtPantQty.Text = "0";
            txtPantPrice.Text = "0.00";
            txtPantTotal.Text = "0.00";
            cmbSuits.Text = "None";
            txtSuitsQty.Text = "0";
            txtSuitsPrice.Text = "0.00";
            txtSuitsTotal.Text = "0.00";
            cmbOuterWear.Text = "None";
            txtOWQty.Text = "0";
            txtOWPrice.Text = "0.00";
            txtOWTotal.Text = "0.00";
            cmbSportsWear.Text = "None";
            txtSWQty.Text = "0";
            txtSWPrice.Text = "0.00";
            txtSWTotal.Text = "0.00";
            cmbFormalWear.Text = "None";
            txtFWQty.Text = "0";
            txtFWPrice.Text = "0.00";
            txtFWTotal.Text = "0.00";
            txtCleaningTotal.Text = "";
            txtTaxRate.Text = "";
            txtTaxAmount.Text = "";
            txtNetPrice.Text = "";


        }
    }
}
