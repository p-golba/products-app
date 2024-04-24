using Refit;
using ProductsApp.Model;

namespace ProductsApp.Services;

public interface IProductsService
 {
     [Post("/Products")]
     Task<Product> PostProduct(Product newProduct);
     
     [Get("/Products")]
     Task<List<Product>> GetProduct();
 }