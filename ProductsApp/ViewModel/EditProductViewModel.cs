using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductsApp.Model;
using ProductsApp.Services;

namespace ProductsApp.ViewModel;

public partial class EditProductViewModel : ObservableObject
{
    private readonly IProductsService _productsService;
    [ObservableProperty] private Product _product;

    public EditProductViewModel(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [RelayCommand]
    public async Task GetProduct(string id)
    {
        var product = await _productsService.GetProduct(id);
        Product = product;
    }

    [RelayCommand]
    public async Task PutProduct()
    {
        
        var product = new Product()
        {
            ProductName = Product.ProductName,
            Price = Product.Price,
            Quantity = Product.Quantity,
            IsAvailable = Product.IsAvailable,
        };

        await _productsService.PutProduct(Product.Id, product);
    }

    [RelayCommand]
    public async Task DeleteProduct()
    {
        await _productsService.DeleteProduct(Product.Id);
    }
}