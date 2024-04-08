using ErpProject.Controllers;
using ErpProject.Interface;
using ErpProject.Models;

namespace ErpProject.Repository
{
    public class ShippingRepository : IShippingRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ShippingRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public ShippingAddress addShippingAddress(ShippingAddress shippingAddress)
        {
            dbContext.ShippingAddresses.Add(shippingAddress);
            dbContext.SaveChanges();
            return shippingAddress;
        }

        public void deleteShippingAddress(int id)
        {
            var shipping = dbContext.ShippingAddresses.Find(id);
            if (shipping != null)
            {
                dbContext.ShippingAddresses.Remove(shipping);
                dbContext.SaveChanges();
            }
            
        }

        public List<ShippingAddress> getAllShippingAddresses()
        {
            return dbContext.ShippingAddresses.ToList();
        }

        public ShippingAddress getShippingAddressById(int id)
        {
            return dbContext.ShippingAddresses.Find(id);
        }

        public ShippingAddress updateShippingAddress(ShippingAddress shippingAddress)
        {
            dbContext.ShippingAddresses.Update(shippingAddress);
            dbContext.SaveChanges();
            return shippingAddress;
        }
    }
}
