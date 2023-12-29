using Feedback.Core.Models.Dto;
using Feedback.Core.Models.ViewModels;

namespace Feedback.Core.Interfaces.DomainServices;

public interface IReviewService
{
    Task SubmitReviewAsync(ReviewDto dto);
    
    Task<List<OrderViewModel>> GetOrders();
    
    Task<List<ReviewViewModel>> GetAllReviewsAsync();
    
    Task <ReviewViewModel> GetReviewByIdAsync(long id);

}