CREATE PROCEDURE [dbo].[sp_GetAssessedAccountsForPayment]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        a.[AssessmentID],
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
        sec.[SectionName],
        e.[SchoolYear],
        a.[TuitionFee],
        a.[MiscellaneousFee],
        a.[OtherFees],
        a.[DiscountAmount],
        a.[TotalAmount] AS [TotalAssessed],
        ISNULL(SUM(p.[AmountPaid]), 0.00) AS [TotalPaid],
        a.[TotalAmount] - ISNULL(SUM(p.[AmountPaid]), 0.00) AS [RemainingBalance],
        CASE 
            WHEN ISNULL(SUM(p.[AmountPaid]), 0.00) <= 0 THEN 'Unpaid'
            WHEN (a.[TotalAmount] - ISNULL(SUM(p.[AmountPaid]), 0.00)) <= 0 THEN 'Paid'
            ELSE 'Partial'
        END AS [PaymentStatus]
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
    LEFT JOIN 
        [dbo].[Payments] p ON a.[AssessmentID] = p.[AssessmentID] AND p.[IsActive] = 1
    WHERE 
        a.[IsActive] = 1
        AND e.[IsActive] = 1
        AND st.[IsActive] = 1
    GROUP BY 
        a.[AssessmentID], e.[EnrollmentID], e.[StudentID],
        st.[StudentNumber], st.[LastName], st.[FirstName], st.[MiddleName],
        g.[GradeLevelName], sec.[SectionName], e.[SchoolYear],
        a.[TuitionFee], a.[MiscellaneousFee], a.[OtherFees], a.[DiscountAmount], a.[TotalAmount]
    ORDER BY 
        e.[SchoolYear] DESC, st.[LastName] ASC, st.[FirstName] ASC;
END