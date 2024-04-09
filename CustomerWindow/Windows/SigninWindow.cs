using Newtonsoft.Json.Linq;
using RestaurantFrontEnd;
using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Services;
namespace CustomerWindow
{
    public partial class SigninWindow : Form
    {
        private ISigninService signinService;
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
            //login.UserName = userName.Text;
            //login.Password = password.Text;
            login.UserName = "joydip";
            login.Password = "joydip123";
            if (!isValidInput(login))
            {
                MessageBox.Show("Empty login details to the system: " + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    signinService.LoginWithBasicCredentials(login);
                    dispalyMainWindow();
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

        private void dispalyMainWindow()
        {
            Form mainWindow = new RestaurantsMainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private bool isValidInput(Login login)
        {
            return !(string.IsNullOrEmpty(login.UserName) ||
                               string.IsNullOrEmpty(login.Password));
        }

        private void signupClick(object sender, EventArgs e)
        {
            MessageBox.Show(MPHVaultTools.MPHVault.Lookup("WebService"));
        }
    }
}
