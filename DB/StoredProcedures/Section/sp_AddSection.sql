CREATE PROCEDURE [dbo].[sp_AddSection]
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
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('This section already exists for the selected grade level and school year.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Sections] 
        WHERE [SectionName] = @SectionName 
          AND [GradeLevelID] = @GradeLevelID 
          AND [SchoolYear] = @SchoolYear
          AND [IsActive] = 0
    )
    BEGIN
        UPDATE [dbo].[Sections]
        SET 
            [IsActive] = 1,
            [Adviser] = @Adviser,
            [MaxCapacity] = @MaxCapacity
        WHERE [SectionName] = @SectionName 
          AND [GradeLevelID] = @GradeLevelID 
          AND [SchoolYear] = @SchoolYear;
        RETURN;
    END

    INSERT INTO [dbo].[Sections] ([SectionName], [GradeLevelID], [SchoolYear], [Adviser], [MaxCapacity])
    VALUES (@SectionName, @GradeLevelID, @SchoolYear, @Adviser, @MaxCapacity);
END