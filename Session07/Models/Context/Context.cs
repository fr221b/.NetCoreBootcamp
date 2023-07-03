using Microsoft.EntityFrameworkCore;
public class Context : DbContext
{
       //Override OnConfiguring method
       public DbSet<Student> Students { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=Edu;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
       }
}