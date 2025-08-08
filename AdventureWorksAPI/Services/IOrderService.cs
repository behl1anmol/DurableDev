using System.Runtime.CompilerServices;
using AdventureWorksAPI.Models;

namespace AdventureWorksAPI.Services;

public interface IOrderService
{
    IEnumerable<GetSalesOrderDetailsSpModel> GetSalesOrderDetails(int salesOrderId);
}