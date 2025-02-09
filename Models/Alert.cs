public class Alert
{
    public int Id { get; set; }
    
    [Required]
    public string UserId { get; set; } // Link para Identity User
    
    [Required]
    public string AssetSymbol { get; set; } // FK para Asset
    
    [Column(TypeName = "decimal(18, 8)")]
    public decimal Threshold { get; set; }
    
    [Required]
    public ConditionType Condition { get; set; }
    
    public bool IsActive { get; set; } = true;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? TriggeredAt { get; set; }
    
    // Relacionamentos
    [ForeignKey("AssetSymbol")]
    public Asset Asset { get; set; }
    
    public ICollection<Notification> Notifications { get; set; }
}

public enum ConditionType
{
    GreaterThan,
    LessThan,
    PercentIncrease,
    PercentDecrease,
    VolumeSpike
}