


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public EmployeeAddress EmployeeAddress { get; set; }
    public int EmployeeAddressId { get; set; }
}