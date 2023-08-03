
using System.ComponentModel.DataAnnotations;
namespace Core.Domain.User;
public class MUser
{
    [Key]
    public int Id { get; set;}
    public int Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Token { get; set; }
    
}