namespace Patterns.Sergey.Interfaces
{
    interface IProduct
    {
        string Title { get; }
        int Number { get; set; }
        double Price { get; set; }
        event ProductArrivedHandler Update;

        void Subscribe(IShop shop);
        void Unsubscribe(IShop shop);
        void Notify();
    }
}
