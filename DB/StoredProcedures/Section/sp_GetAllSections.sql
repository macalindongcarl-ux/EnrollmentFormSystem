CREATE PROCEDURE [dbo].[sp_GetAllSections]
    @IncludeInactive BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.[SectionID],
        s.[SectionName],
        s.[GradeLevelID],
        g.[GradeLevelName],
        s.[SchoolYear],
        s.[Adviser],
        s.[MaxCapacity],
        s.[IsActive]
    FROM 
        [dbo].[Sections] s
    INNER JOIN 
        [dbo].[GradeLevels] g ON s.[GradeLevelID] = g.[GradeLevelID]
    WHERE 
        (@IncludeInactive = 1 OR s.[IsActive] = 1)
    ORDER BY 
        s.[IsActive] DESC, s.[SchoolYear] DESC, g.[GradeLevelID] ASC, s.[SectionName] ASC;
END