using System.ComponentModel.DataAnnotations;

public class Student 
{
    
        [Key]    
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
}