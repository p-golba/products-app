using ProductsApp.Model;
using ProductsApp.ViewModel;

namespace ProductsApp.View;

public partial class ProductsList : ContentPage
{
    private readonly ProductsListViewModel _productsListViewModel;

    public ProductsList(ProductsListViewModel productsListViewModel)
    {
        InitializeComponent();
        BindingContext = productsListViewModel;
        _productsListViewModel = productsListViewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await _productsListViewModel.LoadProducts();
    }

    private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Console.WriteLine(((Product) e.SelectedItem).Id);
    }
}