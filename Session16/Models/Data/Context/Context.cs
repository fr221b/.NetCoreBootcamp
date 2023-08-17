


using Microsoft.EntityFrameworkCore;
using Session16.Models.Data.Entities;

namespace Session16.Models.Data.Context;

public class Context : DbContext
{
         public DbSet<Tbl_Product> Tbl_Products { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CQRSFirstDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
         }
}