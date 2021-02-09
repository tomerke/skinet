using System.Collections.Generic;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
       [Req]
        public string Id { get; set; }
        public  List<BasketItemDto> Items  { get; set; }
    }
}