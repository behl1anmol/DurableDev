using AdventureWorksAPI.Models;

namespace AdventureWorksAPI.Repositories;

public interface IOrderRepository
{
    List<GetSalesOrderDetailsSpModel> GetOrderDetails(int salesOrderId);
}