﻿namespace api;

public class Comment
{
    public int ID { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public int? StockId { get; set; }
    public Stocks? Stock { get; set; }

}
