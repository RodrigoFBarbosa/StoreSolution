using System.ComponentModel.DataAnnotations;

namespace StoreSolution.Domain.Entities;

internal class User
{
    [Key]
    public Guid UserId { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(150)]
    public string? UserName { get; set; }
    [Required]
    public string? PasswordHash { get; set; }
    [Required]
    public bool IsAdmin { get; set; }
}
