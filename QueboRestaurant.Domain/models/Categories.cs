using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;

public class Categories
{
    [Key]
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
