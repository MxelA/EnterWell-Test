using System.ComponentModel.DataAnnotations;

namespace EnterWellTest.Domain.Entities
{
    public class Invoice : Entity
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string InvoiceCode { get; set; } = null!;
        public DateTimeOffset DueDate { get; set; }
        public decimal PriceWithoutTax { get; set; }
        public decimal PriceWithTax { get; set; }
        public string Customer { get; set; } = string.Empty;
        public User User { get; set; } = null!;
        public ICollection<InvoiceItem> InvoiceItems { get; set; } = null!;
    }
}
