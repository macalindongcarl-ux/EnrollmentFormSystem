CREATE PROCEDURE [dbo].[sp_AuthenticateUser]
    @Username NVARCHAR(50),
    @Password NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [UserID],
        [Username],
        [IsAdmin]
    FROM 
        [dbo].[Users]
    WHERE 
        [Username] = @Username 
        AND [Password] = @Password;
END