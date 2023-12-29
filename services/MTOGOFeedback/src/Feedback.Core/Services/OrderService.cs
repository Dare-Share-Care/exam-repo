using Feedback.Core.Interfaces.DomainServices;
using Feedback.Core.Models.ViewModels;
using Grpc.Core;
using Grpc.Net.Client;
using OrderNameSpace;

namespace Feedback.Core.Services;

public class OrderService : IOrderService
{
    public async Task<List<OrderViewModel>> GetCompletedOrdersAsync(long userId)
    {
        const string grpcServerUrl = "http://mtogo-orders-grpc:8001";
        var channel = GrpcChannel.ForAddress(grpcServerUrl);
        var client = new Review.ReviewClient(channel);
        var request = new ReviewRequest { UserId = userId };
        try
        {
            var response = await client.SendOrdersForReviewAsync(request);
            var orders = response.Orders;
            var orderViewModels = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                // Map the gRPC response to your ViewModel
                var orderViewModel = new OrderViewModel()
                {
                    UserId = order.UserId,
                    OrderId = order.Id,
                    TimeCreated = order.TimeCreated,
                    Status = order.Status,
                    Total = order.Total,
                };

                foreach (var orderLine in order.OrderLines)
                {
                    var orderLineViewModel = new OrderLineViewModel()
                    {
                        MenuItemName = orderLine.MenuItemName,
                        MenuItemId = orderLine.MenuItemId,
                        Quantity = (int)orderLine.Quantity,
                        Price = orderLine.Price
                    };
                    orderViewModel.OrderLines.Add(orderLineViewModel);
                }
                orderViewModels.Add(orderViewModel);
            }
            return orderViewModels;
        }
        catch (RpcException ex)
        {
            throw new Exception($"gRPC Error: {ex.Status.Detail}", ex);
        }
    }


    
}