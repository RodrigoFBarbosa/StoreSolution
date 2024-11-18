using StoreSolution.Domain.Entities;

namespace StoreSolution.Domain.Interfaces;

internal interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrdersByUserAsync(Guid userId);
    Task<Order?> GetByIdAsync(Guid id);
    Task AddAsync(Order order);
}
