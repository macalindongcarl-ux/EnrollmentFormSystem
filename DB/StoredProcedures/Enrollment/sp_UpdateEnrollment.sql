CREATE PROCEDURE [dbo].[sp_UpdateEnrollment]
    @EnrollmentID INT,
    @StudentID INT,
    @GradeLevelID INT,
    @SectionID INT,
    @SchoolYear NVARCHAR(20),
    @EnrollmentDate DATE,
    @Status NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Prevent duplicate active enrollment for the same student and school year (excluding current record)
    IF @Status = 'Enrolled' AND EXISTS (
        SELECT 1 
        FROM [dbo].[Enrollments]
        WHERE [StudentID] = @StudentID
          AND [SchoolYear] = @SchoolYear
          AND [EnrollmentID] <> @EnrollmentID
          AND [IsActive] = 1
          AND [Status] = 'Enrolled'
    )
    BEGIN
        RAISERROR('This student already has another active enrollment for the selected school year.', 16, 1);
        RETURN;
    END

    -- 2. Validate section capacity (excluding current record)
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
          AND [EnrollmentID] <> @EnrollmentID
          AND [IsActive] = 1
          AND [Status] = 'Enrolled';

        IF @CurrentEnrolled >= @MaxCapacity
        BEGIN
            RAISERROR('The selected section has already reached its maximum capacity.', 16, 1);
            RETURN;
        END
    END

    UPDATE [dbo].[Enrollments]
    SET 
        [StudentID] = @StudentID,
        [GradeLevelID] = @GradeLevelID,
        [SectionID] = @SectionID,
        [SchoolYear] = @SchoolYear,
        [EnrollmentDate] = @EnrollmentDate,
        [Status] = @Status
    WHERE 
        [EnrollmentID] = @EnrollmentID;
END