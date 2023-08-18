using Microsoft.EntityFrameworkCore;
using Session17.Models.Entities;


namespace Session17.Models.Context;
public class Context : DbContext
{
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=Login;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
       }
}