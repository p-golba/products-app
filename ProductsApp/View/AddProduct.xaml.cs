namespace ProductsApp.View;

public partial class AddProduct : ContentPage
{
    public AddProduct()
    {
        InitializeComponent();
    }

    private async void OnAddProductCancelClicked(object sender, EventArgs eventArgs)
    {
        await Navigation.PopAsync();
    }
}