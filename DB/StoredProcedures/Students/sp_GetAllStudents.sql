CREATE PROCEDURE [dbo].[sp_GetAllStudents]
    @IncludeInactive BIT = 0,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [StudentID],
        [StudentNumber],
        [FirstName],
        [MiddleName],
        [LastName],
        [DateOfBirth],
        [Gender],
        [Address],
        [ContactNumber],
        [Email],
        [GuardianName],
        [GuardianContact],
        [IsActive],
        [DateCreated]
    FROM 
        [dbo].[Students]
    WHERE 
        (@IncludeInactive = 1 OR [IsActive] = 1)
        AND (
            @SearchTerm IS NULL 
            OR @SearchTerm = ''
            OR [StudentNumber] LIKE '%' + @SearchTerm + '%'
            OR [FirstName] LIKE '%' + @SearchTerm + '%'
            OR [LastName] LIKE '%' + @SearchTerm + '%'
            OR ([FirstName] + ' ' + [LastName]) LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY 
        [IsActive] DESC, [LastName] ASC, [FirstName] ASC;
END