using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;

namespace Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> orderRepo;
        private readonly IGenericRepository<DeliveryMethod> dmRepo;
        private readonly IGenericRepository<Product> productRepo;
        private readonly IBasketRepository basketRepo;


        public OrderService(IGenericRepository<Order> orderRepo, IGenericRepository<DeliveryMethod> dmRepo,
        IGenericRepository<Product> productRepo, IBasketRepository basketRepo)
        {
           orderRepo = orderRepo;
            this.dmRepo = dmRepo;
            this.productRepo = productRepo;
            this.basketRepo = basketRepo;
        }

        public Task<Order> CreateOrderAsync(string buyerEmail, int deliveryMethod, string basketId, Address shippingAddress)
        {
            //get basket from repo

            //get items from the product repo
            //get delivery method from repo
            //calc subtotal
            //create order
            //save to db
            //return order
        }

        public Task<IReadOnlyList<DeliveryMethod>> GetDeleiveryMethotsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> GetOrderByIdAsync(int id, string buyerEmail)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string buyerEmail)
        {
            throw new System.NotImplementedException();
        }
    }
}