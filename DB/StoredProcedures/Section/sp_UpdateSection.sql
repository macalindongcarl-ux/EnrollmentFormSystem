CREATE PROCEDURE [dbo].[sp_UpdateSection]
    @SectionID INT,
    @SectionName NVARCHAR(50),
    @GradeLevelID INT,
    @SchoolYear NVARCHAR(20),
    @Adviser NVARCHAR(100) = NULL,
    @MaxCapacity INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Sections] 
        WHERE [SectionName] = @SectionName 
          AND [GradeLevelID] = @GradeLevelID 
          AND [SchoolYear] = @SchoolYear
          AND [SectionID] <> @SectionID
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('Another section with the same name already exists for this grade level and school year.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[Sections]
    SET 
        [SectionName] = @SectionName,
        [GradeLevelID] = @GradeLevelID,
        [SchoolYear] = @SchoolYear,
        [Adviser] = @Adviser,
        [MaxCapacity] = @MaxCapacity
    WHERE 
        [SectionID] = @SectionID;
END