CREATE PROCEDURE [dbo].[sp_DeactivateUser]
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Users] 
        WHERE [UserID] = @UserID 
          AND [Role] = 'Admin' 
          AND [IsActive] = 1
    )
    BEGIN
        IF (SELECT COUNT(*) FROM [dbo].[Users] WHERE [Role] = 'Admin' AND [IsActive] = 1) <= 1
        BEGIN
            RAISERROR('Cannot deactivate the last active Admin account.', 16, 1);
            RETURN;
        END
    END

    UPDATE [dbo].[Users]
    SET [IsActive] = 0
    WHERE [UserID] = @UserID;
END