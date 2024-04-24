using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductsApp.Model;
using ProductsApp.Services;

namespace ProductsApp.ViewModel;

public partial class ProductViewModel : ObservableObject
{
    private readonly IProductsService _service;

    public ProductViewModel(IProductsService service)
    {
        _service = service;
    }

    [ObservableProperty] private string _productName;
    [ObservableProperty] private decimal _price;
    [ObservableProperty] private int _quantity;
    [ObservableProperty] private bool _isAvailable;

    [RelayCommand]
    private async Task PostProduct()
    {
        var product = new Product()
        {
            ProductName = ProductName,
            Price = Price,
            Quantity = Quantity,
            IsAvailable = IsAvailable,
        };

        await _service.PostProduct(product);
        await Application.Current!.MainPage!.Navigation.PopAsync();
    }
}