public class InventoryTransaction
{
    public Guid Id { get; set; }
    public DateTime TransactionDate { get; set; }
    public TranscationEnum TransactionType { get; set; }
    public string ReferenceNumber { get; set; } = string.Empty; // invoice / po number
    public string? Notes { get; set; }
    public required ICollection<TransactionDetail> Items { get; set; } = [];
}