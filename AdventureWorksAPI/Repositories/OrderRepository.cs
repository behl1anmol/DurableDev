using AdventureWorksAPI.Entities;
using AdventureWorksAPI.Models;
using AdventureWorksAPI.Services;

namespace AdventureWorksAPI.Repositories;

public class OrderRepository(IOrderService _orderService) : IOrderRepository
{
    public List<GetSalesOrderDetailsSpModel> GetOrderDetails(int salesOrderId)
    {
        var orders = _orderService.GetSalesOrderDetails(salesOrderId).ToList();
        return orders;
    }
}