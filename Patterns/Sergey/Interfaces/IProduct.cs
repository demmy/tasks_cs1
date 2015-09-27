namespace Patterns.Sergey.Interfaces
{
    interface IProduct
    {
        string Title { get; }
        int Number { get; set; }
        double Price { get; set; }
    }
}
