using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public record RefundPaymentRequest
    {
        [Required]
        public string Provider { get; set; } = null!;

        [Required]
        public string TransactionId { get; init; } = null!;

        [Range(0.01, double.MaxValue)]
        public decimal? Amount { get; init; }

        [Required]
        public string Currency { get; init; } = "TRY";

        public string? Reason { get; init; }
        public Dictionary<string, object>? MetaData { get; init; }
    }
    //(string OrderNumber,decimal Amount, string Currency);
}
