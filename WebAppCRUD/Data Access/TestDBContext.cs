using System.Data.Entity;
using WebAppCRUD.Models;

namespace WebAppCRUD.Data_Access
{
    public class TestDBContext : DbContext
    {
        public TestDBContext() : base("TestConnection")
        {

        }

        public DbSet<Table> Table { get; set; }
    }
}