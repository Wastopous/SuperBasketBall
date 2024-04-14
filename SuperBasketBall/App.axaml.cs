using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SuperBasketBall.ViewModels;
using SuperBasketBall.Views;

namespace SuperBasketBall;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new EnterWin();
            {
 
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}