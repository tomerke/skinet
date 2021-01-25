using System.Collections.Generic;

namespace Core.Entities
{
    public class CustomerBasket
    {
        public int Id { get; set; }
        public  List<BasketItem> Item  { get; set; }

        
    }
}