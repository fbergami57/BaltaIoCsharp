Product mouse = new Product();

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);


struct Product
{

    public Product(int Id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int Id;
    public string Name;
    public double Price;

    public double PriceInDollar(double dollar)
    {
        return Price * dollar;
    }
}