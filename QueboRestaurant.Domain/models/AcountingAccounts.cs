using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;

public class AcountingAccounts
{
    [Key]
    public int AccountAccountId { get; set; }
    public int Code { get; set; }
    public string Description { get; set; }
}
