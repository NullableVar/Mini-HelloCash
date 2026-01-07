using System.ComponentModel.DataAnnotations;

namespace Mini_HelloCash.DataAccess.Database.Entities;

public class Role
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string RoleName { get; set; } = null!;
}
