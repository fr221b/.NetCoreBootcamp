using Microsoft.EntityFrameworkCore;

namespace Sample01.Models
{
public class Context :DbContext
{
       public DbSet<User> Users { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=Shop;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
}
}
}