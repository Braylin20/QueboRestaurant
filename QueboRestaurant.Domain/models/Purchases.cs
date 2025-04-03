
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueboRestaurant.Domain.models;

public class Purchases
{
    [Key]
    public int PurchasesId { get; set; }
    [ForeignKey("PaymentMethodId")]
    public int PaymentMethodId { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
}
