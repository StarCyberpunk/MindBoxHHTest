CREATE TABLE Products(id INT PRIMARY KEY, name NVARCHAR(255) NOT NULL);
CREATE TABLE Category(id INT PRIMARY KEY, name NVARCHAR(255) NOT NULL);
CREATE TABLE ProdCat(products_id INT NOT NULL, category_id INT NOT NULL);
INSERT INTO Products VALUES(1, N'Молоко'), (2, N'Вода'), (3, N'Мыло');
INSERT INTO Category VALUES(1, N'Продукты'), (2, N'Хоз-товары');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);
SELECT prod.name [Продукт], cat.name [Категория] FROM Products prod
    LEFT JOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;