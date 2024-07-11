using System.Linq;
using Microsoft.UI.Input;
using Microsoft.UI.Xaml;
using Windows.Graphics;
using Microsoft.UI.Xaml.Controls;
using WinRT;
using WinUI3Utilities;

namespace IconExplorer;

public sealed partial class MainWindow
{
    public MainWindow()
    {
        AppWindow.Changed += MainWindow_OnSizeChanged;
        InitializeComponent();
    }

    private void MainWindow_OnSizeChanged(object sender, IWinRTObject args)
    {
        var tabView = Content.To<TabView>();
        var inputNonClientPointerSource = InputNonClientPointerSource.GetForWindowId(AppWindow.Id);
        inputNonClientPointerSource.SetRegionRects(NonClientRegionKind.Caption, [new(0, 0, AppWindow.Size.Width, 48)]);
        inputNonClientPointerSource.ClearRegionRects(NonClientRegionKind.Passthrough);
        inputNonClientPointerSource.SetRegionRects(NonClientRegionKind.Passthrough,
            tabView.TabItems.Cast<UIElement>().Select(t => GetScaledRect(t)).ToArray());
    }

    private RectInt32 GetScaledRect(UIElement uiElement, RectInt32? r = null)
    {
        if (r is { } rect)
        {
            var scaleFactor = uiElement.XamlRoot?.RasterizationScale ?? 0;
            return new((int)(rect.X * scaleFactor), (int)(rect.Y * scaleFactor), (int)(rect.Width * scaleFactor),
                (int)(rect.Height * scaleFactor));
        }
        else
        {
            var pos = uiElement.TransformToVisual(null).TransformPoint(new(0, 0));
            rect = new RectInt32((int)pos.X, (int)pos.Y, (int)uiElement.ActualSize.X, (int)uiElement.ActualSize.Y);
            return GetScaledRect(uiElement, rect);
        }
    }
}
