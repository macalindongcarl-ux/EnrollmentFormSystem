CREATE PROCEDURE [dbo].[sp_UpdateStudent]
    @StudentID INT,
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

    UPDATE [dbo].[Students]
    SET 
        [FirstName] = @FirstName,
        [MiddleName] = @MiddleName,
        [LastName] = @LastName,
        [DateOfBirth] = @DateOfBirth,
        [Gender] = @Gender,
        [Address] = @Address,
        [ContactNumber] = @ContactNumber,
        [Email] = @Email,
        [GuardianName] = @GuardianName,
        [GuardianContact] = @GuardianContact
    WHERE 
        [StudentID] = @StudentID;
END