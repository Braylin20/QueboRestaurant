using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueboRestaurant.Domain.models;
public class Reconciliations
{
    [Key]
    public int ReconciliationId { get; set; }
    [ForeignKey("ExpensesId")]
    public int ExpensesId { get; set; }
    public double TotalAmountSold { get; set; }
    public int PettyCash { get; set; }
    public double TotalCash { get; set; }
    public double TotalCreditCard { get; set; }
    public DateTime Date { get; set; }

}
