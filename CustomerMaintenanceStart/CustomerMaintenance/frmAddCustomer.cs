using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()    // Returns the customer if it has been saved
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, EventArgs e)      // Saves the customer if the data in the fields is valid
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text,
                    txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                   Validator.IsPresent(txtLastName) &&
                   Validator.IsPresent(txtEmail) &&
                   Validator.IsValidEmail(txtEmail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}