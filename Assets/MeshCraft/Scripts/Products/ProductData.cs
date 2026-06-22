using System;

[Serializable]
public class Product
{
    public string id;
    public string name;
    public string type;
    public float price;
}

[Serializable]
public class ProductList
{
    public Product[] products;
}