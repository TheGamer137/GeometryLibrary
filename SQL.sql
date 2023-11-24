SELECT 
    Products.ProductName,
    ISNULL(Categories.CategoryName, '��� ���������') AS CategoryName
FROM 
    Products
LEFT JOIN 
    ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN 
    Categories ON ProductCategory.CategoryID = Categories.CategoryID;
