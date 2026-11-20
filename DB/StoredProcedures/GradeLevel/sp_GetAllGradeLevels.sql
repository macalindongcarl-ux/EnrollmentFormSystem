CREATE PROCEDURE [dbo].[sp_GetAllGradeLevels]
    @IncludeInactive BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [GradeLevelID],
        [GradeLevelName],
        [TuitionFee],
        [MiscellaneousFee],
        [IsActive]
    FROM 
        [dbo].[GradeLevels]
    WHERE 
        (@IncludeInactive = 1 OR [IsActive] = 1)
    ORDER BY 
        [IsActive] DESC, [GradeLevelID] ASC;
END