

using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Menu;

public class ModelMenu
{
    [Key]
    public int Id { get; set; }
    public string CatName { get; set; }
    public int ParentId { get; set; }
    public bool Status { get; set; }
    public string? ParentName { get; set; }
}