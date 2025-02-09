public class Asset
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string Symbol { get; set; } // Ex: "BTC-USD", "PETR4.SAO"
    
    [MaxLength(100)]
    public string Name { get; set; } // Ex: "Bitcoin", "Petrobras PN"
    
    [Required]
    public AssetType Type { get; set; } // Enum: Stock, Crypto, Commodity
    
    [Column(TypeName = "decimal(18, 8)")]
    public decimal CurrentPrice { get; set; }
    
    public DateTime LastUpdated { get; set; }
    
    // Relacionamentos
    public ICollection<PriceHistory> PriceHistory { get; set; }
}

public enum AssetType
{
    Stock,
    Cryptocurrency,
    Forex,
    Commodity,
    Index
}