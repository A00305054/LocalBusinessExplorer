using Microsoft.Maui;
using Microsoft.UI.Xaml;

namespace LocalBusinessExplorer.WinUI
{
    public partial class App : MauiWinUIApplication
    {
        public App()
        {
            // Windows-specific initialization
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
