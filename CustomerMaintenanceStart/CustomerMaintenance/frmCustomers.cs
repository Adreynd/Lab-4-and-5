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

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private List<Customer> customers = null;

        private void frmCustomers_Load(object sender, EventArgs e)      // When the form loads...
        {
            customers = CustomerDB.GetCustomers();      // Grab the customers out of the database
            FillCustomerListBox();                      // Then fill the list box with them
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();                 // Clear the list box
            foreach (Customer c in customers)           // Fill the list box with customers
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)           // When the user clicks the add button, give them a form to fill out to create a new customer
        {
            frmAddCustomer newCustomerForm = new frmAddCustomer();      // Create the form
            Customer customer = newCustomerForm.GetNewCustomer();       // Get the information from the form
            if (customer != null)
            {
                customers.Add(customer);                // Create, save, and show the new customer
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)        // When the user clicks the delete button with a customer selected, ask if they are sure, then if they say yes, delete it
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];           // Get the customer they clicked
                string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)             // Delete the customer if they say yes
                {
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}