using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueboRestaurant.Domain.models;

public class Sales
{
    [Key]
    public int SaleId { get; set; }
    [ForeignKey("ClientId")]
    public int ClientId { get; set; }
    [ForeignKey("PaymentMethodId")]
    public int PaymentMethodId { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    [ForeignKey("SaleId")]
    public ICollection<SalesDetails> SalesDetails { get; set; } = new List<SalesDetails>();
}
