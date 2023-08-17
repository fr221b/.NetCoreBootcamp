


using System.ComponentModel.DataAnnotations;

namespace Session16.Models.Data.Entities;

public class Tbl_Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Color { get; set; }

}