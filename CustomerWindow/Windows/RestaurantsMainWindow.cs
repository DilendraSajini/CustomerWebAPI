using RestaurantFrontEnd.Services;

namespace RestaurantFrontEnd
{
    public partial class RestaurantsMainWindow : Form
    {
        private CustomerService customerService = new CustomerService();
        public RestaurantsMainWindow()
        {
            InitializeComponent();
            setDataGridDataSource();
        }

        private void setDataGridDataSource()
        {
            dataGridView.Columns["FirstName"].DataPropertyName = "FirstName";
            dataGridView.Columns["SurName"].DataPropertyName = "SurName";
            dataGridView.Columns["FullName"].DataPropertyName = "FullName";
            dataGridView.Columns["Gender"].DataPropertyName = "Gender";
            dataGridView.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dataGridView.Columns["Email"].DataPropertyName = "Email";
            dataGridView.Columns["TransactionNumber"].DataPropertyName = "TransactionNumber";
            dataGridView.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dataGridView.Columns["PostalCode"].DataPropertyName = "PostalCode";
            dataGridView.Columns["Address"].DataPropertyName = "Address";
            dataGridView.DataSource = customerService.getCustomers();
        }
    }
}
