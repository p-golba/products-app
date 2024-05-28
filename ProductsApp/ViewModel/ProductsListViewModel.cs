using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ProductsApp.Model;
using ProductsApp.Services;

namespace ProductsApp.ViewModel;

public partial class ProductsListViewModel : ObservableObject
{
    private readonly IProductsService _productsService;

    public ProductsListViewModel(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [ObservableProperty] private ObservableCollection<Product> _productsList = new ObservableCollection<Product>();

    public async Task LoadProducts()
    {
        var products = await _productsService.GetProducts();
        ProductsList.Clear();
        foreach (var product in products)
        {
            ProductsList.Add(product);
        }
    }
}