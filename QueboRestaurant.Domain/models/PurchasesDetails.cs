

using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;

public class PurchasesDetails
{
    [Key]
    public int PurchasesDetailsId { get; set; }
    public int PurchasesId { get; set; }
    public int AccountingAccountId { get; set; }
    public string ProductName { get; set; }
    public double Quantity { get; set; }
    public double Price { get; set; }
    public double Total { get; set; }
}
