namespace _01_Classes.Classes;

internal class Product
{
    /* private fields */
    private decimal discount = 10.0m;



    /* public Properties */
    public string ArticleNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }



    /* private/public Methods */
    public void ApplyDiscount()
    {
        Price = Price - discount;
    }

    public string GetProductInformation()
    {
        return $"{Name} ({Price})";
    }



    /* Constructors - snippet ctor */
    public Product()
    {

    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public Product(string articleNumber, string name, string description, decimal price)
    {
        ArticleNumber = articleNumber;
        Name = name;
        Description = description;
        Price = price;
    }
}
