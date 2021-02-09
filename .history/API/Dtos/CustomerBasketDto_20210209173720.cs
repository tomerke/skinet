using System.Collections.Generic;
using Core.Entities;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
        public string Id { get; set; }
        public  List<BasketItemD> Items  { get; set; } = new List<BasketItem>();
    }
}