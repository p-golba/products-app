using ProductsApp.View;

namespace ProductsApp;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAddProductBtnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddProduct());
    }
}