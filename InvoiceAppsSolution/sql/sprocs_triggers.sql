USE InvoiceAppsDb;
GO

DROP TRIGGER IF EXISTS trg_Employee_Audit;
GO

CREATE TRIGGER trg_Employee_Audit
ON dbo.Employees
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.EmployeeAudit (EmployeeId, Action, EventTime)
    SELECT 
        COALESCE(i.Id, d.Id) AS EmployeeId,
        CASE 
            WHEN i.Id IS NOT NULL AND d.Id IS NULL THEN 'INSERT'
            WHEN i.Id IS NOT NULL AND d.Id IS NOT NULL THEN 'UPDATE'
            WHEN i.Id IS NULL AND d.Id IS NOT NULL THEN 'DELETE'
        END AS Action,
        SYSUTCDATETIME()
    FROM inserted i
    FULL OUTER JOIN deleted d ON i.Id = d.Id;
END
GO
