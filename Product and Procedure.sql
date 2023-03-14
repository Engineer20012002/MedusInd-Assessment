USE master;
CREATE DATABASE product;
GO
USE product;

create table product
         (ProductNo DECIMAL(2) CONSTRAINT pk_product PRIMARY KEY,
		 Name VARCHAR(14),unitprice DECIMAL(5),category VARCHAR(10));

INSERT INTO Product VALUES(10,'Highlander',500,'Myntra');
INSERT INTO Product Values(20,'Adidas',600,'Amazon');
INSERT INTO product Values(30,'Puma',700,'Flipkart');
INSERT INTO product Values(40,'Reebok',800,'Ajio');

select*from product;

CREATE PROCEDURE GetFruitProducts
AS
BEGIN
    SELECT * FROM FruitProducts WHERE Category = 'Fruits'
END
exec product9