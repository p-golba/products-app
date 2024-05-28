using ProductsApp.ViewModel;

namespace ProductsApp.View;

public partial class EditProduct : ContentPage
{
    private readonly string _id;
    private readonly EditProductViewModel _editProductViewModel;
    public EditProduct(string id, EditProductViewModel editProductViewModel)
    {
        InitializeComponent();
        BindingContext = editProductViewModel;
        _editProductViewModel = editProductViewModel;
        _id = id;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await _editProductViewModel.GetProduct(_id);
    }

    private async void AddProductSaveBtn_OnClicked(object sender, EventArgs e)
    {
        await _editProductViewModel.PutProduct();
        await Navigation.PopAsync();
    }

    private async void AddProductCancelBtn_OnClicked(object sender, EventArgs e)
    {
        await _editProductViewModel.DeleteProduct();
        await Navigation.PopAsync();
    }
}