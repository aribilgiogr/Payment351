using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    // record: Sınıflar yerine DTO (Data Transfer Object) gibi sadece veri tutan yapılar için kullanılır. Parametreler otomatik olarak oluşturulur ve immutable (değiştirilemez) olur.
    public record ProcessPaymentRequest
    {
        [Required]
        public string Provider { get; set; } = null!;

        [Required]
        public string OrderNumber { get; init; } = null!;

        [Required, Range(0.01, double.MaxValue)]
        public decimal TotalAmount { get; init; }

        [Required]
        public string Currency { get; init; } = "TRY";

        public string? Description { get; init; }
        public Dictionary<string, object>? MetaData { get; init; }
    }
    //(string OrderNumber,decimal TotalAmount, string Currency);
}
