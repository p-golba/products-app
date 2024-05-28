using Refit;
using ProductsApp.Model;

namespace ProductsApp.Services;

public interface IProductsService
 {
     [Post("/Products")]
     Task<Product> PostProduct(Product newProduct);
     
     [Get("/Products")]
     Task<List<Product>> GetProducts();

     [Get("/Products/{id}")]
     Task<Product> GetProduct(string id);

     [Put("/Products/{id}")]
     Task PutProduct(string id, Product updatedProduct);

     [Delete("/Products/{id}")]
     Task DeleteProduct(string id);
 }