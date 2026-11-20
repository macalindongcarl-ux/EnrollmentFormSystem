CREATE PROCEDURE [dbo].[sp_AddGradeLevel]
    @GradeLevelName NVARCHAR(50),
    @TuitionFee DECIMAL(10,2) = 0.00,
    @MiscellaneousFee DECIMAL(10,2) = 0.00
AS
BEGIN
    SET NOCOUNT ON;

    IF @TuitionFee < 0 OR @MiscellaneousFee < 0
    BEGIN
        RAISERROR('Tuition and Miscellaneous fees cannot be negative.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[GradeLevels] 
        WHERE [GradeLevelName] = @GradeLevelName 
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('Grade level already exists.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[GradeLevels] 
        WHERE [GradeLevelName] = @GradeLevelName 
          AND [IsActive] = 0
    )
    BEGIN
        UPDATE [dbo].[GradeLevels]
        SET 
            [IsActive] = 1,
            [TuitionFee] = @TuitionFee,
            [MiscellaneousFee] = @MiscellaneousFee
        WHERE [GradeLevelName] = @GradeLevelName;
        RETURN;
    END

    INSERT INTO [dbo].[GradeLevels] ([GradeLevelName], [TuitionFee], [MiscellaneousFee])
    VALUES (@GradeLevelName, @TuitionFee, @MiscellaneousFee);
END