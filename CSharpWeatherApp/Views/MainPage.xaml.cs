using CSharpWeatherApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace CSharpWeatherApp.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
