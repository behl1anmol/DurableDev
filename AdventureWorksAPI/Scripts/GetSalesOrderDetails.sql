CREATE PROCEDURE GetSalesOrderDetails
    @SalesOrderID INT
AS
BEGIN
SELECT
    SOD.SalesOrderID,
    SOD.SalesOrderDetailID,
    SOD.OrderQty,
    SOD.UnitPrice,
    SOD.UnitPriceDiscount,
    SOH.OrderDate,
    SOH.DueDate,
    SOH.ShipDate,
    P.Name AS ProductName,
    PC.Name AS CategoryName,
    PM.Name AS ModelName
FROM SalesLT.SalesOrderDetail SOD
         JOIN SalesLT.SalesOrderHeader SOH ON SOD.SalesOrderID = SOH.SalesOrderID
         JOIN SalesLT.Product P ON SOD.ProductID = P.ProductID
         JOIN SalesLT.ProductCategory PC ON P.ProductCategoryID = PC.ProductCategoryID
         JOIN SalesLT.ProductModel PM ON P.ProductModelID = PM.ProductModelID
WHERE SOD.SalesOrderID = @SalesOrderID
END

--EXEC GetSalesOrderDetails @SalesOrderID = 71774;