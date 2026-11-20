CREATE PROCEDURE [dbo].[sp_GetEnrolledStudentsForAssessment]
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
        g.[GradeLevelName],
        g.[TuitionFee] AS [DefaultTuitionFee],
        g.[MiscellaneousFee] AS [DefaultMiscellaneousFee],
        sec.[SectionName],
        e.[SchoolYear]
    FROM 
        [dbo].[Enrollments] e
    INNER JOIN 
        [dbo].[Students] st ON e.[StudentID] = st.[StudentID]
    INNER JOIN 
        [dbo].[GradeLevels] g ON e.[GradeLevelID] = g.[GradeLevelID]
    INNER JOIN 
        [dbo].[Sections] sec ON e.[SectionID] = sec.[SectionID]
    WHERE 
        e.[IsActive] = 1
        AND e.[Status] = 'Enrolled'
        AND st.[IsActive] = 1
    ORDER BY 
        e.[SchoolYear] DESC, st.[LastName] ASC, st.[FirstName] ASC;
END