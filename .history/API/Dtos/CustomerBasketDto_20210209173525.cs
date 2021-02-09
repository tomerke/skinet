namespace API.Dtos
{
    public class CustomerBasketDto
    {
        public string Id { get; set; }
        public  List<BasketItem> Items  { get; set; } = new List<BasketItem>();
    }
}