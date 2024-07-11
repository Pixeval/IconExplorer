using Microsoft.UI.Xaml;
using WinUI3Utilities;

namespace IconExplorer;

public partial class App
{
    public App() => InitializeComponent();

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Initialize(new());
        _window.Activate();
    }

    private Window _window = null!;
}
