--Select
Select ContactName Adi,CompanyName ŞirketAdi,City  Şehir from Customers

Select * from Customers where City='Berlin'

select * from Products where CategoryID=1 or categoryId=3
select * from Products where CategoryID=1 and UnitPrice>10

select * from Products order by CategoryID

select * from Products order by UnitPrice asc --ascending

select * from Products where categoryId =1 order by UnitPrice desc --descanding

select count(*) from Products -- sadece şarta uyan datayı verir
select count(*)  Adet from Products  where categoryId =2

select count(*)  Adet from Products

select categoryID,count(*) from Products group by CategoryID
select categoryID,ProductName,count(*) from Products group by CategoryID,ProductName

select categoryID,count(*) from Products  group by CategoryID having count(*)<10

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10


select *from Products inner join Categories on Products.CategoryID =Categories.CategoryID


 select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
 from Products inner join Categories on Products.CategoryID =Categories.CategoryID
 where Products.UnitPrice >10

 select * from Products p inner join [Order Details] od 
 on p.ProductID=od.ProductID
 inner join Orders o on o.OrderID=od.OrderID

 select * from Customers c left join Orders o 
 on c.CustomerID=o.CustomerID
 where o.CustomerID is null







 --DTO Data Transformation object