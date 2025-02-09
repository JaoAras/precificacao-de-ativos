public class PriceHistory
{
    public int Id { get; set; }
    
    [Required]
    public string AssetSymbol { get; set; }
    
    [Column(TypeName = "decimal(18, 8)")]
    public decimal Price { get; set; }
    
    public DateTime Timestamp { get; set; }
    
    [MaxLength(10)]
    public string Interval { get; set; } // Ex: "1h", "4h", "1d"
    
    // Relacionamentos
    [ForeignKey("AssetSymbol")]
    public Asset Asset { get; set; }
}