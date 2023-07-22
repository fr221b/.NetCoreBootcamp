using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities.User;
public class TblUser
{
    [Key]
    public int Id { get; set;}
    public int Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Token { get; set; }

}