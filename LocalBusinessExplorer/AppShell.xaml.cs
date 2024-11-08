using LocalBusinessExplorer.Views;

namespace LocalBusinessExplorer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigating to pages programmatically
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
        }
    }
}
