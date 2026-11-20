CREATE PROCEDURE [dbo].[sp_GetAllPayments]
    @IncludeInactive BIT = 0,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.[PaymentID],
        p.[AssessmentID],
        p.[ReceiptNumber],
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
        p.[AmountPaid],
        p.[PaymentMethod],
        ISNULL(p.[ReferenceNumber], '') AS [ReferenceNumber],
        p.[PaymentDate],
        u.[Username] AS [ProcessedBy],
        p.[IsActive],
        p.[DateCreated]
    FROM 
        [dbo].[Payments] p
    INNER JOIN 
        [dbo].[Assessments] a ON p.[AssessmentID] = a.[AssessmentID]
    INNER JOIN 
        [dbo].[Enrollments] e ON a.[EnrollmentID] = e.[EnrollmentID]
    INNER JOIN 
        [dbo].[Students] st ON e.[StudentID] = st.[StudentID]
    INNER JOIN 
        [dbo].[GradeLevels] g ON e.[GradeLevelID] = g.[GradeLevelID]
    INNER JOIN 
        [dbo].[Sections] sec ON e.[SectionID] = sec.[SectionID]
    INNER JOIN 
        [dbo].[Users] u ON p.[ProcessedByUserID] = u.[UserID]
    WHERE 
        (@IncludeInactive = 1 OR p.[IsActive] = 1)
        AND (
            @SearchTerm IS NULL 
            OR @SearchTerm = ''
            OR p.[ReceiptNumber] LIKE '%' + @SearchTerm + '%'
            OR st.[StudentNumber] LIKE '%' + @SearchTerm + '%'
            OR st.[FirstName] LIKE '%' + @SearchTerm + '%'
            OR st.[LastName] LIKE '%' + @SearchTerm + '%'
            OR (st.[FirstName] + ' ' + st.[LastName]) LIKE '%' + @SearchTerm + '%'
            OR p.[PaymentMethod] LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY 
        p.[IsActive] DESC, p.[PaymentID] DESC;
END