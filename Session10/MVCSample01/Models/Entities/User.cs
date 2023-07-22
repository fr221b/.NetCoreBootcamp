
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MVCSample01.Models;
public class User
{
    [Key]
    public int Id { get; set;}
    public string? Phone { get; set;}
    public string? Code { get; set; }

}