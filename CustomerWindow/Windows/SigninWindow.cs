using RestaurantFrontEnd;
using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Services;
namespace CustomerWindow
{
    public partial class SigninWindow : Form
    {
        private SigninService signinService;
        public SigninWindow()
        {
            InitializeComponent();
            signinService = new SigninService();
        }

        private void signinLoad(object sender, EventArgs e)
        {

        }

        private void signinClick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = userName.Text;
            login.Password = password.Text;
            if (!isValidInput(login))
            {
                MessageBox.Show("Empty login details to the system: " + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    signinService.Login(login);
                    Form mainWindow = new RestaurantsMainWindow();
                    mainWindow.Show();
                    this.Hide();
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
        }

        private bool isValidInput(Login login)
        {
            return !(string.IsNullOrEmpty(login.UserName) ||
                               string.IsNullOrEmpty(login.Password));
        }
    }
}
