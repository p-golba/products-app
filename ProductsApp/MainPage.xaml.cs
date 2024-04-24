using ProductsApp.View;

namespace ProductsApp;

public partial class MainPage
{
    private readonly AddProduct _addProduct;
    private readonly ProductsList _productsList;

    public MainPage(AddProduct addProduct, ProductsList productsList)
    {
        InitializeComponent();
        _addProduct = addProduct;
        _productsList = productsList;
    }

    private async void AddProductBtn_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_addProduct);
    }

    private async void CounterBtn_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_productsList);
    }
}