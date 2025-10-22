-- Create database if missing and core tables (safe to run multiple times)
IF DB_ID('InvoiceAppsDb') IS NULL
BEGIN
    CREATE DATABASE InvoiceAppsDb;
END
GO

USE InvoiceAppsDb;
GO

-- Departments
IF OBJECT_ID('dbo.Departments','U') IS NULL
BEGIN
CREATE TABLE dbo.Departments
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedAt DATETIME2 DEFAULT SYSUTCDATETIME()
);
END
GO

-- Designations
IF OBJECT_ID('dbo.Designations','U') IS NULL
BEGIN
CREATE TABLE dbo.Designations
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500) NULL,
    CreatedAt DATETIME2 DEFAULT SYSUTCDATETIME()
);
END
GO

-- Employees
IF OBJECT_ID('dbo.Employees','U') IS NULL
BEGIN
CREATE TABLE dbo.Employees
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(150) NOT NULL,
    LastName NVARCHAR(150) NULL,
    DepartmentId INT NULL,
    DesignationId INT NULL,
    Salary DECIMAL(18,2) NULL,
    CreatedAt DATETIME2 DEFAULT SYSUTCDATETIME()
);
END
GO

-- EmployeeAudit for trigger logging
IF OBJECT_ID('dbo.EmployeeAudit','U') IS NULL
BEGIN
CREATE TABLE dbo.EmployeeAudit
(
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    Action NVARCHAR(50) NOT NULL,
    EventTime DATETIME2 DEFAULT SYSUTCDATETIME()
);
END
GO

-- FileRecords
IF OBJECT_ID('dbo.FileRecords','U') IS NULL
BEGIN
CREATE TABLE dbo.FileRecords
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FileName NVARCHAR(250) NOT NULL,
    FilePath NVARCHAR(1000) NOT NULL,
    ContentType NVARCHAR(150) NOT NULL,
    UploadedAt DATETIME2 DEFAULT SYSUTCDATETIME()
);
END
GO
