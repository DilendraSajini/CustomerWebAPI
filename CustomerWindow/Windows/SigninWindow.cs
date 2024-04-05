using RestaurantFrontEnd;
using RestaurantFrontEnd.Services;
using RestaurantFrontEnd.Services.Models;
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

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void signinClick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Password = "joydip123";
            login.UserName = "joydip";
            signinService.Login(login);
            Form mainWindow = new RestaurantsMainWindow();
            mainWindow.Show();
        }
    }
}
