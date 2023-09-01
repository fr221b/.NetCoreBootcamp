


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Infrastructure.Data.Entities;
public class EmployeeAddress
{
    [Key]
    [ForeignKey("Employee")]
    public int Id { get; set; }
    public string Address { get; set; }
    //
    //Navigation property Returns the Employee 
    public  Employee Employee { get; set; }
    
 }