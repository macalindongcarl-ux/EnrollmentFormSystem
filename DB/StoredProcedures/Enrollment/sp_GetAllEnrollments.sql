CREATE PROCEDURE [dbo].[sp_GetAllEnrollments]
    @IncludeInactive BIT = 0,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.[EnrollmentID],
        e.[StudentID],
        st.[StudentNumber],
        st.[LastName] + ', ' + st.[FirstName] + 
            CASE 
                WHEN st.[MiddleName] IS NOT NULL AND LTRIM(RTRIM(st.[MiddleName])) <> '' 
                THEN ' ' + LEFT(LTRIM(st.[MiddleName]), 1) + '.' 
                ELSE '' 
            END AS [StudentName],
        e.[GradeLevelID],
        g.[GradeLevelName],
        e.[SectionID],
        sec.[SectionName],
        e.[SchoolYear],
        e.[EnrollmentDate],
        e.[Status],
        e.[IsActive],
        e.[DateCreated]
    FROM 
        [dbo].[Enrollments] e
    INNER JOIN 
        [dbo].[Students] st ON e.[StudentID] = st.[StudentID]
    INNER JOIN 
        [dbo].[GradeLevels] g ON e.[GradeLevelID] = g.[GradeLevelID]
    INNER JOIN 
        [dbo].[Sections] sec ON e.[SectionID] = sec.[SectionID]
    WHERE 
        (@IncludeInactive = 1 OR e.[IsActive] = 1)
        AND (
            @SearchTerm IS NULL 
            OR @SearchTerm = ''
            OR st.[StudentNumber] LIKE '%' + @SearchTerm + '%'
            OR st.[FirstName] LIKE '%' + @SearchTerm + '%'
            OR st.[LastName] LIKE '%' + @SearchTerm + '%'
            OR (st.[FirstName] + ' ' + st.[LastName]) LIKE '%' + @SearchTerm + '%'
            OR g.[GradeLevelName] LIKE '%' + @SearchTerm + '%'
            OR sec.[SectionName] LIKE '%' + @SearchTerm + '%'
            OR e.[SchoolYear] LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY 
        e.[IsActive] DESC, e.[SchoolYear] DESC, e.[EnrollmentDate] DESC, st.[LastName] ASC;
END