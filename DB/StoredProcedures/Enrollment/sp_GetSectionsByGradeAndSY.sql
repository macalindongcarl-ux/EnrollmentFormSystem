CREATE PROCEDURE [dbo].[sp_GetSectionsByGradeAndSY]
    @GradeLevelID INT,
    @SchoolYear NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.[SectionID],
        s.[SectionName],
        s.[GradeLevelID],
        s.[SchoolYear],
        s.[Adviser],
        s.[MaxCapacity],
        (
            SELECT COUNT(*) 
            FROM [dbo].[Enrollments] e 
            WHERE e.[SectionID] = s.[SectionID] 
              AND e.[IsActive] = 1 
              AND e.[Status] = 'Enrolled'
        ) AS [CurrentEnrolled]
    FROM 
        [dbo].[Sections] s
    WHERE 
        s.[GradeLevelID] = @GradeLevelID
        AND s.[SchoolYear] = @SchoolYear
        AND s.[IsActive] = 1
    ORDER BY 
        s.[SectionName] ASC;
END