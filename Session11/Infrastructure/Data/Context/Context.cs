using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Entities.User;
using Infrastructure.Data.Entities.Product;

namespace Infrastructure.Data.Context;
public class Context : DbContext
{
       public DbSet<TblUser> TblUsers { get; set; }
       public DbSet<TblProduct> TblProducts { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=CleanArchitect;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
}
}