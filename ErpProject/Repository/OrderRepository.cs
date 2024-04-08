using ErpProject.Controllers;
using ErpProject.Interface;
using ErpProject.Models;

namespace ErpProject.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext dbContext;
        public OrderRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Order addOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return order;
        }

        public void deleteOrder(int id)
        {
            var order = dbContext.Orders.Find(id);
            if (order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
        }

        public List<Order> getAllOrders()
        {
            return dbContext.Orders.ToList();
        }

        public Order getOrderById(int id)
        {
            return dbContext.Orders.Find(id);
        }

        public Order updateOrder(Order order)
        {
            dbContext.Orders.Update(order);
            dbContext.SaveChanges();
            return order;
        }
    }
}
