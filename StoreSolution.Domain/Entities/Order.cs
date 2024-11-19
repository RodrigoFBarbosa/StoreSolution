using System.ComponentModel.DataAnnotations;

namespace StoreSolution.Domain.Entities;

public class Order
{
    [Key]
    public Guid OrderId { get; set; } = Guid.NewGuid();
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public User? User { get; set; }
    public DateTime OrderDate { get; set; }
    [Required]
    public decimal TotalAmount { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
