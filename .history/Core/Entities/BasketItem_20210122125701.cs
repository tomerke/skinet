 namespace Core.Entities
{
    public class BasketItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int PictureUrl  { get; set; }
        public int MyProperty { get; set; }
    }
}