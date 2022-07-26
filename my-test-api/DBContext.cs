using Microsoft.EntityFrameworkCore;
using my_test_api.Model;

namespace my_test_api
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = "server=localhost; database=dev_db; user=dev; password=devpass";
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        public DbSet<TableUser> User { get; set; }
        public DbSet<TableOrder> Order { get; set; }
    }
}
