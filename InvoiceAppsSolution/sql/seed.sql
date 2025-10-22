USE InvoiceAppsDb;
GO

-- Seed Departments
IF NOT EXISTS (SELECT 1 FROM dbo.Departments)
BEGIN
    INSERT INTO dbo.Departments (Name, Description)
    VALUES 
    ('HR', 'Human Resources Department'),
    ('IT', 'Information Technology'),
    ('Finance', 'Finance & Accounting');
END
GO

-- Seed Designations
IF NOT EXISTS (SELECT 1 FROM dbo.Designations)
BEGIN
    INSERT INTO dbo.Designations (Title, Description)
    VALUES
    ('Manager', 'Department Manager'),
    ('Software Engineer', 'Develops software solutions'),
    ('Accountant', 'Handles finance records');
END
GO

-- Seed Employees
IF NOT EXISTS (SELECT 1 FROM dbo.Employees)
BEGIN
    INSERT INTO dbo.Employees (FirstName, LastName, DepartmentId, DesignationId, Salary)
    VALUES
    ('John', 'Doe', 1, 1, 50000.00),
    ('Alice', 'Smith', 2, 2, 65000.00),
    ('Bob', 'Jones', 3, 3, 45000.00);
END
GO

-- Seed File Records
IF NOT EXISTS (SELECT 1 FROM dbo.FileRecords)
BEGIN
    INSERT INTO dbo.FileRecords (FileName, FilePath, ContentType)
    VALUES
    ('contract.pdf', 'uploads/files/contract.pdf', 'application/pdf'),
    ('profile.jpg', 'uploads/images/profile.jpg', 'image/jpeg');
END
GO
