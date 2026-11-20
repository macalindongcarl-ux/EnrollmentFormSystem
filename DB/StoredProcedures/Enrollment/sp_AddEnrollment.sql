CREATE PROCEDURE [dbo].[sp_AddEnrollment]
    @StudentID INT,
    @GradeLevelID INT,
    @SectionID INT,
    @SchoolYear NVARCHAR(20),
    @EnrollmentDate DATE,
    @Status NVARCHAR(20) = 'Enrolled'
AS
BEGIN
    SET NOCOUNT ON;
     
    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Enrollments]
        WHERE [StudentID] = @StudentID
          AND [SchoolYear] = @SchoolYear
          AND [IsActive] = 1
          AND [Status] = 'Enrolled'
    )
    BEGIN
        RAISERROR('This student is already enrolled for the selected school year.', 16, 1);
        RETURN;
    END
     
    DECLARE @MaxCapacity INT;
    DECLARE @CurrentEnrolled INT;

    SELECT @MaxCapacity = [MaxCapacity]
    FROM [dbo].[Sections]
    WHERE [SectionID] = @SectionID
      AND [GradeLevelID] = @GradeLevelID
      AND [SchoolYear] = @SchoolYear
      AND [IsActive] = 1;

    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('Invalid or inactive section selected for this grade level and school year.', 16, 1);
        RETURN;
    END

    IF @Status = 'Enrolled' AND @MaxCapacity IS NOT NULL
    BEGIN
        SELECT @CurrentEnrolled = COUNT(*)
        FROM [dbo].[Enrollments]
        WHERE [SectionID] = @SectionID
          AND [IsActive] = 1
          AND [Status] = 'Enrolled';

        IF @CurrentEnrolled >= @MaxCapacity
        BEGIN
            RAISERROR('The selected section has already reached its maximum capacity.', 16, 1);
            RETURN;
        END
    END

    INSERT INTO [dbo].[Enrollments] (
        [StudentID], [GradeLevelID], [SectionID],
        [SchoolYear], [EnrollmentDate], [Status]
    )
    VALUES (
        @StudentID, @GradeLevelID, @SectionID,
        @SchoolYear, @EnrollmentDate, @Status
    );
END