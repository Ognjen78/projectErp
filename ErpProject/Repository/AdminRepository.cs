using ErpProject.Controllers;
using ErpProject.Interface;
using ErpProject.Models;

namespace ErpProject.Repository
{
    public class AdminRepository : IAdminRepository
    {

        private readonly ApplicationDbContext dbContext;

        public AdminRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Admin> getAllAdmins()
        {
            return dbContext.Admins.ToList();
        }
        public Admin getAdminById(Guid id)
        {
            return dbContext.Admins.Find(id);
        }
        public Admin addAdmin(Admin admin)
        {
            dbContext.Admins.Add(admin);
            dbContext.SaveChanges();
            return admin;
        }
        public Admin updateAdmin(Admin admin)
        {
            dbContext.Admins.Update(admin);
            dbContext.SaveChanges();
            return admin;
        }
        public void deleteAdmin(Guid id)
        {
            var admin = dbContext.Admins.Find(id);
            if (admin != null)
            {
                dbContext.Admins.Remove(admin);
                dbContext.SaveChanges();
            }

        }
    }
}
