using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double numberofnights = 0;
        double people = 0;
        double priceofroom = 0;
        double extraexpenses = 0;
        double total = 0;
        double amountperperson = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            numberofnights = Convert.ToInt32(txtNumberNights.Text);
            people = Convert.ToInt32(txtNumPeople.Text);
            priceofroom = Convert.ToDouble(txtPriceRoom.Text);
            extraexpenses = (double)Convert.ToDecimal(txtExtra.Text);

            total = numberofnights * priceofroom + extraexpenses;
            amountperperson = total / people;

            lblOutput.Text = "Amount to pay per person is = " + Convert.ToString(amountperperson);
            lblTotal.Text = "Total amount is = " + Convert.ToString(total);

            if (people > 6)
            {
                lblOutputDiscount.Text = "Discount amount is = " + Convert.ToString(total * 0.10);
            }

            if (isValid())
            {
                lblOutput.Text = "Invalid amount";
            }
        }
        private bool isValid()
        {
            if (people == 100)
                return true;
            if (numberofnights == 1000000)
                return true;
            if (extraexpenses == 10000)
                return true;
            return false;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            int emails;
            int[] arr = new int[100];

            if (string.IsNullOrEmpty(txtEmail.Text))
                return;
            Emails.Items.Add(txtEmail.Text);

        }

        private void lblTitle2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Emails.Items.Clear();
        }
    }
    }
    






           