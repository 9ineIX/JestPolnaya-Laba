# Ave Datagrid


```sql
CREATE DATABASE ProductManagerDB;
USE ProductManagerDB;

-- Таблица пользователей
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- Таблица продуктов
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL
);

-- Тестовые данные
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin');
```

