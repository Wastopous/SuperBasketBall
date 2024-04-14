using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SuperBasketBall.Views;

public partial class EnterWin : Window
{
    public static int role;

    public EnterWin()
    {
        InitializeComponent();

    }


    private void Manager_OnClick(object? sender, RoutedEventArgs e)
    {
        role = 1;
        var main = new MainWindow();
        main.Show();
    }

    private void Admin_OnClick(object? sender, RoutedEventArgs e)
    {
        role = 2;
        var main = new MainWindow();
        main.Show();
    }
}