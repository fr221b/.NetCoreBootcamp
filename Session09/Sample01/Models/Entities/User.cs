using System.ComponentModel.DataAnnotations;

namespace Sample01.Models
{
public class User{
[Key]
 public int Id { get; set; }
 public string Name { get; set; }
 public string Email { get; set; }
 public string PhoneNumber { get; set; }
 public string Message { get; set; }
 public string Code { get; set; }
}
}