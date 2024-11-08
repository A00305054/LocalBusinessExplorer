using Microsoft.Maui.Controls;

namespace LocalBusinessExplorer.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            // Navigate back to LoginPage
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
