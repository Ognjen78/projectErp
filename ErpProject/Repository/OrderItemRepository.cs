using ErpProject.Controllers;
using ErpProject.Interface;
using ErpProject.Models;

namespace ErpProject.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ApplicationDbContext dbContext;
        public OrderItemRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public OrderItem addOrderItem(OrderItem orderItem)
        {
            dbContext.OrderItems.Add(orderItem);
            dbContext.SaveChanges();
            return orderItem;
        }

        public void deleteOrderItem(int id)
        {
            var orderItem = dbContext.OrderItems.Find(id);
            if(orderItem != null) 
            {
                dbContext.OrderItems.Remove(orderItem);
                dbContext.SaveChanges() ;
            }
        }

        public List<OrderItem> getAllOrderItems()
        {
            return dbContext.OrderItems.ToList();
        }

        public OrderItem getOrderItemById(int id)
        {
            return dbContext.OrderItems.Find(id);
        }

        public OrderItem updateOrderItem(OrderItem orderItem)
        {
            dbContext.OrderItems.Update(orderItem);
            dbContext.SaveChanges();
            return orderItem;
        }
    }
}
