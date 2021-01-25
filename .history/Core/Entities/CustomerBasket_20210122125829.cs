using System.Collections.Generic;

namespace Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket(int id, List<BasketItem> item)
        {
            Id = id;
            Item = item;
        }

        public int Id { get; set; }
        public  List<BasketItem> Item  { get; set; } = new List<BasketItem>();


    }
}