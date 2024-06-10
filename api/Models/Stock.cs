using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace api;

public class Stocks
{
    public int ID { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string Companyname { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]
    public string Purchase { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]
    public decimal Dividend { get; set; } = decimal.Zero;
    public string  Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>; //check vid 2
}
