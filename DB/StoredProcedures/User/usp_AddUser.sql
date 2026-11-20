CREATE PROCEDURE [dbo].[usp_AddUser]
    @Username NVARCHAR(50),
    @Password NVARCHAR(255),
    @Role NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM [dbo].[Users] WHERE [Username] = @Username)
    BEGIN
        RAISERROR('Username already exists. Please choose another username.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[Users] ([Username], [Password], [Role], [IsActive])
    VALUES (@Username, @Password, @Role, 1);
END
GO