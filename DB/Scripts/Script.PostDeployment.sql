DECLARE @SeedUsers TABLE (
    [Username] NVARCHAR(50),
    [Password] NVARCHAR(255),
    [IsAdmin] BIT
);

-- 2. Populate the default testing accounts
-- NOTE: Passwords are in plain-text here to match your current Stored Procedure testing setup.
INSERT INTO @SeedUsers ([Username], [Password], [IsAdmin]) VALUES
('admin', 'admin123', 1),     -- Default Administrator account
('cashier', 'cashier123', 0); -- Default Cashier/Staff account

-- 3. Safely merge the accounts into the real database table
MERGE INTO [dbo].[Users] AS Target
USING @SeedUsers AS Source
ON (Target.[Username] = Source.[Username])

-- If the user doesn't exist, insert them cleanly
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Username], [Password], [IsAdmin])
    VALUES (Source.[Username], Source.[Password], Source.[IsAdmin]);