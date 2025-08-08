namespace AdventureWorksAPI.Models;

public class GetSalesOrderDetailsSpModel
{
    public int SalesOrderId { get; set; }
    public int SalesOrderDetailId { get; set; }
    public short OrderQty { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal UnitPriceDiscount { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ShipDate { get; set; }
    public required string ProductName { get; set; }
    public required string CategoryName { get; set; }
    public required string ModelName { get; set; }
    
    public static GetSalesOrderDetailsSpModel FromDataReader(System.Data.IDataReader reader)
    {
        return new GetSalesOrderDetailsSpModel
        {
            SalesOrderId = reader.GetInt32(reader.GetOrdinal("SalesOrderID")),
            SalesOrderDetailId = reader.GetInt32(reader.GetOrdinal("SalesOrderDetailID")),
            OrderQty = reader.GetInt16(reader.GetOrdinal("OrderQty")),
            UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
            UnitPriceDiscount = reader.GetDecimal(reader.GetOrdinal("UnitPriceDiscount")),
            OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
            DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
            ShipDate = reader.IsDBNull(reader.GetOrdinal("ShipDate")) ? null : reader.GetDateTime(reader.GetOrdinal("ShipDate")),
            ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
            CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
            ModelName = reader.GetString(reader.GetOrdinal("ModelName"))
        };
    }
}