using ProductsApp.Model;
using ProductsApp.ViewModel;

namespace ProductsApp.View;

public partial class ProductsList : ContentPage
{
    private readonly ProductsListViewModel _productsListViewModel;
    private readonly EditProductViewModel _editProductViewModel;

    public ProductsList(ProductsListViewModel productsListViewModel, EditProductViewModel editProductViewModel)
    {
        InitializeComponent();
        BindingContext = productsListViewModel;
        _productsListViewModel = productsListViewModel;
        _editProductViewModel = editProductViewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await _productsListViewModel.LoadProducts();
    }

    private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushAsync(new EditProduct(((Product)e.SelectedItem).Id, _editProductViewModel));
    }
}