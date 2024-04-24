﻿namespace ProductsApp.Model;

public class Product
{
    public string Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }
}