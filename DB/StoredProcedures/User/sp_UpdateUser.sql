CREATE PROCEDURE [dbo].[sp_UpdateUser]
    @UserID INT,
    @Username NVARCHAR(50),
    @Password NVARCHAR(255) = NULL,
    @Role NVARCHAR(20),
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Users] 
        WHERE [Username] = @Username 
          AND [UserID] <> @UserID
    )
    BEGIN
        RAISERROR('Another user already uses this username.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Users] 
        WHERE [UserID] = @UserID 
          AND [Role] = 'Admin' 
          AND [IsActive] = 1
    )
    AND (@IsActive = 0 OR @Role <> 'Admin')
    BEGIN
        IF (SELECT COUNT(*) FROM [dbo].[Users] WHERE [Role] = 'Admin' AND [IsActive] = 1) <= 1
        BEGIN
            RAISERROR('Cannot deactivate or change the role of the last active Admin.', 16, 1);
            RETURN;
        END
    END

    UPDATE [dbo].[Users]
    SET 
        [Username] = @Username,
        [Password] = CASE 
            WHEN @Password IS NOT NULL AND LTRIM(RTRIM(@Password)) <> '' 
            THEN @Password 
            ELSE [Password] 
        END,
        [Role] = @Role,
        [IsActive] = @IsActive
    WHERE 
        [UserID] = @UserID;
END