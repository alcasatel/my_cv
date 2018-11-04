using System.Data.Entity;

namespace Metanit.Models
{
    public class UserContext :DbContext
    {
        public UserContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLanguage> Languages { get; set; }
        public DbSet<UserEducation> Educations { get; set; }
        public DbSet<UserExperience> Experiences { get; set; }
        public DbSet<UserSkill> Skills { get; set; }
        public DbSet<UserOther> Others { get; set; }
   
    }
}