using System.Collections.Generic;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
       [Reque]
        public string Id { get; set; }
        public  List<BasketItemDto> Items  { get; set; }
    }
}