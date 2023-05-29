using System.ComponentModel.DataAnnotations;

namespace EnterWellTest.Domain.Entities
{
    public class Invoice : Entity
    {
        [Required]
        public string UserId { get; set; } = null!;
        [Required]
        public string InvoiceCode { get; set; } = null!;
        public DateTimeOffset DueDate { get; set; }
        public decimal PriceWithoutTax { get; set; }
        public decimal PriceWithTax { get; set; }
        public string Customer { get; set; } = string.Empty;
    }
}
