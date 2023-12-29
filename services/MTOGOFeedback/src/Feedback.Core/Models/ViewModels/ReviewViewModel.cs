﻿using System.ComponentModel.DataAnnotations;

namespace Feedback.Core.Models.ViewModels;

public class ReviewViewModel 
{
    public long UserId { get; set; }
    public long OrderId { get; set; }
    public string ReviewText { get; set; }

    public DateTime ReviewDate { get; set; } = DateTime.UtcNow;

    [Range(1, 5, ErrorMessage = "Value for {Rating} must be between {1} and {5}.")]
    public int Rating { get; set; }
}