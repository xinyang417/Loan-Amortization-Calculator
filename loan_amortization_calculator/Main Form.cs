/*App name: Vehicle Loan Calculator
  App purpose: Calculate and display different vehicle loan options.
  App developer: Xinyang Li on 3/10/2021. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLoanCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", 
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        //Declare global variables
        double loan, interest, totalLoan, totalInterest;

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            int months = 0;
            double rate = 0, principal = 0, payment = 0,  
                totalPayment = 0, totalPrincipal = 0, rebate = 0;

            try
            {
                //Get input data from textboxes and radio buttons
                //If the user types a zero or leaves it blank, issue an error message
                double.TryParse(loanAmountTextBox.Text, out loan);
                if (loan == 0)
                {
                    MessageBox.Show("Loan amount may not be zero. Please enter a value.",
                        "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loanAmountTextBox.Focus();
                }
                else
                {
                    double.TryParse(aprComboBox.Text, out rate);

                    if (rate == 0)
                    {
                        MessageBox.Show("APR may not be blank. Please select a value.",
                          "Error Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aprComboBox.Focus();
                    }
                    else
                    {
                        rate = Convert.ToDouble(aprComboBox.Text);
                        double.TryParse(rebateTextBox.Text, out rebate);

                        if (rebateCheckBox.Checked && rebate == 0)
                        {
                            MessageBox.Show("Rebate may not be blank. Please select a value.",
                          "Error Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rebateTextBox.Focus();
                        }
                        else
                        {
                            if (sixRadioButton.Checked) months = 6;
                            else if (twelveRadioButton.Checked) months = 12;
                            else if (eightteenRadioButton.Checked) months = 18;
                            else if (twentyfourRadioButton.Checked) months = 24;

                            //Perform calculation 
                            loan = loan - rebate;
                            principal = rate / 100 / 12 * (loan + 0 * Math.Pow(1 + rate / 100 / 12,
                                months)) / ((Math.Pow(1 + rate / 100 / 12, months) - 1) * (1 + rate / 100 / 12 * 0));
                            interest = loan * rate / 100 / 12;


                            //Clear listbox before showing new results
                            resultListBox.Items.Clear();

                            //Format listbox
                            string formatString = "{0,5}{1,12}{2,12}{3,12}{4,12}";

                            //Create loop to show interest, principal, payments, and balance over the loan months
                            for (int monthsCounter = 1; monthsCounter <= months; monthsCounter++)
                            {
                                payment = principal + interest;
                                loan = loan - principal; 

                                //Display the results in listbox.
                                resultListBox.Items.Add(string.Format(formatString,
                                    monthsCounter,
                                    interest.ToString("C2"),
                                    principal.ToString("N2"),
                                    payment.ToString("N2"),
                                    loan.ToString("N2")));

                                //Calculate the totals
                                totalPrincipal += principal;
                                totalInterest += interest;
                                totalPayment += payment;

                                //Recalculate the interest based on the new loan amount
                                interest = loan * rate / 100 / 12;

                                //Recalculate the principle based on the new interest amount
                                principal = payment - interest;
                            }
                            //Output a blank line and the total
                            resultListBox.Items.Add("");
                            resultListBox.Items.Add(string.Format("{0,5}{1,12}{2,12}{3,12}",
                                "Total ",
                                totalInterest.ToString("C2"),
                                totalPrincipal.ToString("N2"),
                                totalPayment.ToString("N2")));
                        }
                    }
                }   
                
            }

            catch (Exception err)
            {
                //Issue error message and reset focus
                MessageBox.Show(err.Message, "Error Message");
                loanAmountTextBox.Focus();
            }

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //Accumulate the amount of all loans and interest amounts.
            totalInterest += interest;
            double.TryParse(loanAmountTextBox.Text, out loan); //Get the input from loan amount textbox
            totalLoan += loan;

            //Clear the textboxes, combobox, listbox, and labels. 
            loanAmountTextBox.Clear();
            aprComboBox.Text = "";
            rebateTextBox.Clear();
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";

            //Uncheck rebate and disable rebate textbox.
            rebateCheckBox.Checked = false;
            rebateTextBox.Enabled = false;

            //Set months back to 6
            sixRadioButton.Checked = true;

            //CLear the total labels
            totalInterestLabel.Text = null;
            totalLoanLabel.Text = null;

            //Set focus back to loan amount;
            loanAmountTextBox.Focus();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            totalLoanLabel.Text = totalLoan.ToString("C2");
            totalInterestLabel.Text = totalInterest.ToString("C2");
        }

        private void loanAmountTextBox_Click(object sender, EventArgs e)
        {
            //Select all of the loan amount when the user clicks that field
            loanAmountTextBox.SelectAll();
        }

        private void loanAmountTextBox_Enter(object sender, EventArgs e)
        {
            //Select all of the loan amount when the user enters data
            loanAmountTextBox.SelectAll();
        }

        private void loanAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallow any user input except numbers, the period symbol or control keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void loanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user enters new data
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Add the combobox items
            aprComboBox.Items.Add(0.5); aprComboBox.Items.Add(1.0); aprComboBox.Items.Add(1.5); 
            aprComboBox.Items.Add(2.0); aprComboBox.Items.Add(2.5); aprComboBox.Items.Add(3.0); 
            aprComboBox.Items.Add(3.5); aprComboBox.Items.Add(4.0); aprComboBox.Items.Add(4.5); 
            aprComboBox.Items.Add(5.0); aprComboBox.Items.Add(5.5); aprComboBox.Items.Add(6.0); 
            aprComboBox.Items.Add(6.5); aprComboBox.Items.Add(7.0); aprComboBox.Items.Add(7.5); 
            aprComboBox.Items.Add(8.0); aprComboBox.Items.Add(8.5); aprComboBox.Items.Add(9.0); 
            aprComboBox.Items.Add(9.5); aprComboBox.Items.Add(10.0); aprComboBox.Items.Add(10.5); 
            aprComboBox.Items.Add(11.0); aprComboBox.Items.Add(11.5); aprComboBox.Items.Add(12.0);

            // Set default index
            aprComboBox.SelectedIndex = 13;
        }

        private void aprComboBox_Click(object sender, EventArgs e)
        {
            //Select all of the APR when the user click on that field
            aprComboBox.SelectAll();
        }

        private void aprComboBox_Enter(object sender, EventArgs e)
        {
            //Select all of the APR when the user enter new value
            aprComboBox.SelectAll();
        }

        private void aprComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This event handler only allows numbers, the period symbol, and control keys. 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void aprComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the listbox when the user change selection
            resultListBox.Items.Clear();
        }

        private void aprComboBox_TextChanged(object sender, EventArgs e)
        {
            // Clear the listbox and totals when the user enter new value
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void rebateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //Enable the rebate textbox when the rebate checkbox is checked
            rebateTextBox.Enabled = (rebateCheckBox.CheckState == CheckState.Checked);
            rebateTextBox.Focus();

            //CLear rebate textbox when rebate checkbox is unchecked
            if (rebateCheckBox.CheckState == CheckState.Unchecked) rebateTextBox.Clear();

            //Clear the listbox when rebate checkbox is checked or unchecked
            resultListBox.Items.Clear();

            //CLear the totals when rebate checkbox is checked or unchecked
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            // Select all of the rebate value when the user click on that field
            rebateTextBox.SelectAll();
        }

        private void rebateTextBox_Enter(object sender, EventArgs e)
        {
            //Select all of the rebate value when the user enters data
            rebateTextBox.SelectAll();
        }

        private void rebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallow any user input except numbers, the period symbol or control keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user inputs new data
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void sixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user changes loan months
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void twelveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user changes loan months
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void eightteenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user changes loan months
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        private void twentyfourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the listbox and totals when the user changes loan months
            resultListBox.Items.Clear();
            totalInterestLabel.Text = " ";
            totalLoanLabel.Text = " ";
        }

        //Change the button colors when the mouse hovers and leaves
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(27, 73, 66);
            exitButton.ForeColor = Color.White;
        }

        private void calcButton_MouseEnter(object sender, EventArgs e)
        {
            calcButton.BackColor = Color.FromArgb(27, 73, 66);
            calcButton.ForeColor = Color.White;
        }

        private void acceptButton_MouseEnter(object sender, EventArgs e)
        {
            acceptButton.BackColor = Color.FromArgb(27, 73, 66);
            acceptButton.ForeColor = Color.White;
        }

        private void displayButton_MouseEnter(object sender, EventArgs e)
        {
            displayButton.BackColor = Color.FromArgb(27, 73, 66);
            displayButton.ForeColor = Color.White;
        }

        private void calcButton_MouseLeave(object sender, EventArgs e)
        {
            calcButton.BackColor = Color.FromArgb(231, 237, 236);
            calcButton.ForeColor = Color.Black;
        }

        private void displayButton_MouseLeave(object sender, EventArgs e)
        {
            displayButton.BackColor = Color.FromArgb(231, 237, 236);
            displayButton.ForeColor = Color.Black;
        }

        private void acceptButton_MouseLeave(object sender, EventArgs e)
        {
            acceptButton.BackColor = Color.FromArgb(231, 237, 236);
            acceptButton.ForeColor = Color.Black;
        }     

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(231, 237, 236);
            exitButton.ForeColor = Color.Black;
        }

    }
    
}
