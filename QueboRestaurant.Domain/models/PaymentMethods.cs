using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;

public class PaymentMethods
{
    [Key]
    public int PaymentMethodId { get; set; }
    public string Description { get; set; }
}
