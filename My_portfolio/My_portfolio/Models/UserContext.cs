using System.Data.Entity;

namespace Metanit.Models
{
    public class UserContext :DbContext
    {
        public UserContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
    }
}