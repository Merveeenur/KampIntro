select p.ProductName As [Ürün Adı], sum( od.Quantity * od.UnitPrice) As [Kazanılan Toplam Miktar]
from Products p inner join [Order Details] od on od.ProductID =p.ProductID  inner join Orders O  on od.OrderID=O.OrderID
Group By p.ProductName
Order BY p.ProductName