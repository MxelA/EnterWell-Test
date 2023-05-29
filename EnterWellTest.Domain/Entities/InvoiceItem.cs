using System.ComponentModel.DataAnnotations;

namespace EnterWellTest.Domain.Entities
{
    public class InvoiceItem : Entity
    {
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal PriceWithoutTax { get; set; }
        public decimal PriceWithTax { get; set; }
        public virtual Invoice? Invoice { get; set; }
    }
}
