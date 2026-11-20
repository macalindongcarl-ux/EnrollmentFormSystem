CREATE  PROCEDURE [dbo].[sp_GetAllUsers]
    @IncludeInactive BIT = 1,
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [UserID],
        [Username],
        [Password],
        [Role],
        [IsActive],
        [DateCreated]
    FROM 
        [dbo].[Users]
    WHERE 
        (@IncludeInactive = 1 OR [IsActive] = 1)
        AND (
            @SearchTerm IS NULL 
            OR @SearchTerm = ''
            OR [Username] LIKE '%' + @SearchTerm + '%'
            OR [Role] LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY 
        [IsActive] DESC,
        CASE [Role]
            WHEN 'Admin' THEN 1
            WHEN 'Registrar' THEN 2
            WHEN 'Cashier' THEN 3
            ELSE 4
        END,
        [Username] ASC;
END