using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mini_HelloCash.DataAccess.Database.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public Guid RoleId { get; set; }

    [ForeignKey(nameof(RoleId))]
    public Role Role { get; set; } = null!;

    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Username { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;
}
