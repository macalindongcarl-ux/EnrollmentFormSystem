CREATE PROCEDURE [dbo].[sp_DeactivateGradeLevel]
    @GradeLevelID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Sections] 
        WHERE [GradeLevelID] = @GradeLevelID 
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('Cannot delete this grade level because it still has active sections.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[GradeLevels]
    SET [IsActive] = 0
    WHERE [GradeLevelID] = @GradeLevelID;
END