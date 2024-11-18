using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StoreSolution.Domain.Entities;

internal class Product
{
    [Key]
    public Guid ProductId { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(150)]
    public string? Name { get; set; }
    [Required]
    [StringLength(300)]
    public string? Description { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal? Price { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public int Stock { get; set; }
    public  DateTime RegistrationDate { get; set; }
    public Guid CategoryId { get; set; }
    [JsonIgnore]
    public Category? Category { get; set; }
}
