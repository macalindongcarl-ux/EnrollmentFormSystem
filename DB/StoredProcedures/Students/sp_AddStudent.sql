CREATE PROCEDURE [dbo].[sp_AddStudent]
    @FirstName NVARCHAR(50),
    @MiddleName NVARCHAR(50) = NULL,
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(15),
    @Address NVARCHAR(255),
    @ContactNumber NVARCHAR(20) = NULL,
    @Email NVARCHAR(100) = NULL,
    @GuardianName NVARCHAR(100),
    @GuardianContact NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @YearPrefix NVARCHAR(4) = CAST(YEAR(GETDATE()) AS NVARCHAR(4));
    DECLARE @NextSeq INT;
    DECLARE @GeneratedStudentNumber NVARCHAR(30);

    -- Get the next sequence number based on existing records for the current year
    SELECT @NextSeq = ISNULL(MAX(CAST(RIGHT([StudentNumber], 4) AS INT)), 0) + 1
    FROM [dbo].[Students]
    WHERE [StudentNumber] LIKE @YearPrefix + '-%';

    SET @GeneratedStudentNumber = @YearPrefix + '-' + RIGHT('0000' + CAST(@NextSeq AS NVARCHAR(4)), 4);

    INSERT INTO [dbo].[Students] (
        [StudentNumber], [FirstName], [MiddleName], [LastName],
        [DateOfBirth], [Gender], [Address], [ContactNumber],
        [Email], [GuardianName], [GuardianContact]
    )
    VALUES (
        @GeneratedStudentNumber, @FirstName, @MiddleName, @LastName,
        @DateOfBirth, @Gender, @Address, @ContactNumber,
        @Email, @GuardianName, @GuardianContact
    );
END