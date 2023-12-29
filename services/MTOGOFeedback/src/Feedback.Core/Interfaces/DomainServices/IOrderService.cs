using Feedback.Core.Models.ViewModels;

namespace Feedback.Core.Interfaces.DomainServices;

public interface IOrderService
{
    Task<List<OrderViewModel>> GetCompletedOrdersAsync(long userId);
}