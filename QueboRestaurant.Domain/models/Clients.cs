using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;
public class Clients
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string? RNC { get; set; }
}
