using System;
using System.Text;

class Order 
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer) 
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product) 
    {
        products.Add(product);
    }

    public double GetTotal() 
    {
        double total = products.Sum(p => p.GetPrice());
        if (customer.IsInUSA()) {
            total += 5.0;
        } 
        else 
        {
            total += 35.0;
        }
        return total;
    }

    public string GetPackingContents() 
    {
        StringBuilder stringbuilder = new StringBuilder();
        foreach (Product p in products) 
        {
            stringbuilder.Append($"{p.GetName()} ({p.GetId()})\n");
        }
        return stringbuilder.ToString();
    }
    
    public string GetPackingLabel()
    {
        return $"\nPACKING LABEL:\n{GetPackingContents()}";
    }

    public string GetShippingLabel() 
    {
        return $"SHIPPING LABEL:\n{customer.GetName()}\n{customer.GetAddress().GetAddress()}";
    }
}
