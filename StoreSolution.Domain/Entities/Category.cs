using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace StoreSolution.Domain.Entities;

internal class Category
{
    public Category()
    {
        Products = new Collection<Product>();
    }
    [Key]
    public Guid CategoryId { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(80)]
    public string? Name { get; set; }
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public ICollection<Product>? Products { get; set; }
}
