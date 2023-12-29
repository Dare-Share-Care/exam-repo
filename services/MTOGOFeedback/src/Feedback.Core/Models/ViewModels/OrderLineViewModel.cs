namespace Feedback.Core.Models.ViewModels;

public class OrderLineViewModel
{
    public string MenuItemName { get; set; }
    public long MenuItemId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
}