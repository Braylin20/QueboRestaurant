using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueboRestaurant.Domain.models;
public class Products
{
    [Key]
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double Cost { get; set; }
    public int Cuantity { get; set; }
    public double Itbis { get; set; }
    [ForeignKey("Categories")]
    public int CategoryId { get; set; }
    public Categories Categories { get; set; }

}
