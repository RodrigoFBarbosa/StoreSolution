using System.ComponentModel.DataAnnotations;

namespace StoreSolution.Domain.Entities;

internal class OrderItem
{
    [Key]
    public Guid OrderItemId { get; set; } = Guid.NewGuid();
    [Required]
    public Guid OrderId { get; set; }
    [Required]
    public Guid ProductId { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public Product? Product { get; set; }
}
