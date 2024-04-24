using ProductsApp.ViewModel;

namespace ProductsApp.View;

public partial class AddProduct
{
    public AddProduct(ProductViewModel productViewModel)
    {
        InitializeComponent();
        BindingContext = productViewModel;
    }

    private async void AddProductCancelBtn_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}