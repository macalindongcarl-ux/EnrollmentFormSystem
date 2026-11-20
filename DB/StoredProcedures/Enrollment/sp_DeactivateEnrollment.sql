CREATE PROCEDURE [dbo].[sp_DeactivateEnrollment]
    @EnrollmentID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Enrollments]
    SET [IsActive] = 0
    WHERE [EnrollmentID] = @EnrollmentID;
END