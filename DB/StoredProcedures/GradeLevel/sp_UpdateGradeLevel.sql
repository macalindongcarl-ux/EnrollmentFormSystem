CREATE PROCEDURE [dbo].[sp_UpdateGradeLevel]
    @GradeLevelID INT,
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
          AND [GradeLevelID] <> @GradeLevelID
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('Another active grade level already uses this name.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[GradeLevels]
    SET 
        [GradeLevelName] = @GradeLevelName,
        [TuitionFee] = @TuitionFee,
        [MiscellaneousFee] = @MiscellaneousFee
    WHERE 
        [GradeLevelID] = @GradeLevelID;
END