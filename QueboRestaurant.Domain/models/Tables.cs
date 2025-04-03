using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueboRestaurant.Domain.models;
public class Tables
{
    [Key]
    public int TableId { get; set; }
    [ForeignKey("SalesId")]
    public int SalesId { get; set; }
    public string TableName { get; set; }

}
