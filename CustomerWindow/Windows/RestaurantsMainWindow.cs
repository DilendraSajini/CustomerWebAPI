using RestaurantFrontEnd.Services.Services;

namespace RestaurantFrontEnd
{
    public partial class RestaurantsMainWindow : Form
    {
        private ICustomerService customerService;
        private ISigninService signinService;
        public RestaurantsMainWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
            signinService = new SigninService();
            setDataGridDataSource();
        }
        private void mainWindowLoad(object sender, EventArgs e)
        {
            windowsSignIn();
        }
        private void windowsSignIn()
        {
            try
            {
                signinService.LoginWithWindowsCredentials();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Error login to the system: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the system: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void signOutClick(object sender, EventArgs e)
        {

        }
    }
}
