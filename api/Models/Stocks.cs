using System.ComponentModel.DataAnnotations.Schema;

namespace api;

public class Stocks
{
    public int ID { get; set; }
    public string symbol { get; set; } = string.Empty
    public string Companyname { get; set; } = string.Empty
    [Column(TypeName = "decimal(18,2)")]
    public string Purchase { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public int MyProperty { get; set; }
}
