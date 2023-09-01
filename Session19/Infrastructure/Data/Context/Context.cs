



using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context;
public class Context : DbContext
{
       public DbSet<Tbl_Menu> Tbl_Menus { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Employee> Employees { get; set; }
       public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=MenuDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
       } 


}