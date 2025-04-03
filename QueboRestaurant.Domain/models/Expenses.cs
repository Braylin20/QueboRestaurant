using System.ComponentModel.DataAnnotations;

namespace QueboRestaurant.Domain.models;
public class Expenses
{
    [Key]
    public int ExpenseId { get; set; }
    public string Description { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }
}
