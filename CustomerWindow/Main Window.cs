using CustomerWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindow
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            customerListInitialize();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customerList_Click(object sender, EventArgs e)
        {
        }

            private void customerListInitialize()
        {
            List<Customer> customerList = new List<Customer>();
            Customer cus1 = new Customer
            {
                FirstName = "firstName1",
                SurName = "surName1",
                FullName = "fullName1",
                Gender = "gender1",
                BirthDate = "birthDate1",
                Email = "email1",
                TransactionNumber = "transactionNumber1",
                PhoneNumber = "phoneNumber1",
                City = "city1",
                Town = "town1",
                District = "district1",
                Street = "street1",
                PostalCode = "postalCode1",
                Address = "address1"
            };
            customerList.Add(cus1);
            dataGridView1.Columns["FirstName"].DataPropertyName = "FirstName";
            dataGridView1.Columns["SurName"].DataPropertyName = "SurName";
            dataGridView1.Columns["FullName"].DataPropertyName = "FullName";
            dataGridView1.Columns["Gender"].DataPropertyName = "Gender";
            dataGridView1.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dataGridView1.Columns["Email"].DataPropertyName = "Email";
            dataGridView1.Columns["TransactionNumber"].DataPropertyName = "TransactionNumber";
            dataGridView1.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dataGridView1.Columns["PostalCode"].DataPropertyName = "PostalCode";
            dataGridView1.Columns["Address"].DataPropertyName = "Address";
            dataGridView1.DataSource = customerList;

        }

        private void customerCreate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
