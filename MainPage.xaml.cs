using System;
using Microsoft.Maui.Controls;

namespace Signup2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text?.Trim();
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ErrorLabel.Text = "All fields are required.";
                ErrorLabel.IsVisible = true;
                return;
            }

            if (password != confirmPassword)
            {
                ErrorLabel.Text = "Passwords do not match.";
                ErrorLabel.IsVisible = true;
                return;
            }

            ErrorLabel.IsVisible = false;

            // Navigate with URI-based navigation and pass data as query parameters
            await Shell.Current.GoToAsync($"{nameof(ProfilePage)}?username={Uri.EscapeDataString(username)}&email={Uri.EscapeDataString(email)}");
        }
    }
}
