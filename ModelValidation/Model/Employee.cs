namespace ModelValidation.Model;
public class Employee
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
}