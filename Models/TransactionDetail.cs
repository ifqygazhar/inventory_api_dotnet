public class TransactionDetail
{
    public int Id { get; set; }
    public Guid InventoryTransactionId { get; set; }
    public InventoryTransaction InventoryTransaction { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int WarehouseId { get; set; } // From/to warehouse based on transaction type
    public int Quantity { get; set; } // Moving amount
}