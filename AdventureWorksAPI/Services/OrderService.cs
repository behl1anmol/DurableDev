using AdventureWorksAPI.Context;
using AdventureWorksAPI.Entities;
using AdventureWorksAPI.Models;
using Microsoft.Data.SqlClient;

namespace AdventureWorksAPI.Services;

public class OrderService(AdventureWorksContext _context) : IOrderService
{
    private const string GetSalesOrderDetailsStoredProcedure = "GetSalesOrderDetails";
    public IEnumerable<GetSalesOrderDetailsSpModel> GetSalesOrderDetails(int salesOrderId)
    {
        return _context.ExecuteStoredProcedure<GetSalesOrderDetailsSpModel>(
            GetSalesOrderDetailsStoredProcedure,
            new SqlParameter("@SalesOrderId", salesOrderId)
        ).AsEnumerable();
    }
}