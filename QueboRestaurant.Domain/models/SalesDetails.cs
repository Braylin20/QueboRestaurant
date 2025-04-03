using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;
public class SalesDetails
{
    [Key]
    public int SalesDetailsId { get; set; }
    public int SalesId { get; set; }
    public int ProductId { get; set; }
    public int Cuantity { get; set; }
    public double TotalItbis { get; set; }
    public double TotalPrice { get; set; }
}
