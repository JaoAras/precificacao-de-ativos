public class Notification
{
    public int Id { get; set; }
    
    [Required]
    public int AlertId { get; set; }
    
    [MaxLength(500)]
    public string Message { get; set; }
    
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
    
    public NotificationStatus Status { get; set; } = NotificationStatus.Sent;
    
    [Required]
    public NotificationChannel Channel { get; set; }
    
    // Relacionamentos
    [ForeignKey("AlertId")]
    public Alert Alert { get; set; }
}

public enum NotificationStatus
{
    Sent,
    Delivered,
    Failed,
    PendingRetry
}

public enum NotificationChannel
{
    Email,
    SMS,
    Push,
    Webhook
}