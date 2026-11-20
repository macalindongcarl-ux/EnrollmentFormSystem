CREATE PROCEDURE [dbo].[sp_DeactivateStudent]
    @StudentID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Students]
    SET [IsActive] = 0
    WHERE [StudentID] = @StudentID;
END