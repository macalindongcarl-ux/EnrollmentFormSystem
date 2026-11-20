CREATE PROCEDURE [dbo].[sp_GetAllAssessments]
    @IncludeInactive BIT = 0,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        a.[AssessmentID],
        a.[EnrollmentID],
        e.[StudentID],
        st.[StudentNumber],
        st.[LastName] + ', ' + st.[FirstName] + 
            CASE 
                WHEN st.[MiddleName] IS NOT NULL AND LTRIM(RTRIM(st.[MiddleName])) <> '' 
                THEN ' ' + LEFT(LTRIM(st.[MiddleName]), 1) + '.' 
                ELSE '' 
            END AS [StudentName],
        g.[GradeLevelName],
        sec.[SectionName],
        e.[SchoolYear],
        a.[TuitionFee],
        a.[MiscellaneousFee],
        a.[OtherFees],
        a.[DiscountAmount],
        a.[TotalAmount],
        a.[AssessmentDate],
        a.[IsActive],
        a.[DateCreated]
    FROM 
        [dbo].[Assessments] a
    INNER JOIN 
        [dbo].[Enrollments] e ON a.[EnrollmentID] = e.[EnrollmentID]
    INNER JOIN 
        [dbo].[Students] st ON e.[StudentID] = st.[StudentID]
    INNER JOIN 
        [dbo].[GradeLevels] g ON e.[GradeLevelID] = g.[GradeLevelID]
    INNER JOIN 
        [dbo].[Sections] sec ON e.[SectionID] = sec.[SectionID]
    WHERE 
        (@IncludeInactive = 1 OR a.[IsActive] = 1)
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
        a.[IsActive] DESC, a.[AssessmentDate] DESC, st.[LastName] ASC;
END