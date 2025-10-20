using Microsoft.Maui.Controls;

namespace Signup2
{
    [QueryProperty(nameof(Username), "username")]
    [QueryProperty(nameof(Email), "email")]
    public partial class ProfilePage : ContentPage
    {
        private string username;
        private string email;

        public string Username
        {
            get => username;
            set
            {
                username = Uri.UnescapeDataString(value ?? string.Empty);
                UsernameLabel.Text = $"Username: {username}";
            }
        }

        public string Email
        {
            get => email;
            set
            {
                email = Uri.UnescapeDataString(value ?? string.Empty);
                EmailLabel.Text = $"Email: {email}";
            }
        }

        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnSignOutClicked(object sender, EventArgs e)
        {
            // Navigate back to Signup Page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
