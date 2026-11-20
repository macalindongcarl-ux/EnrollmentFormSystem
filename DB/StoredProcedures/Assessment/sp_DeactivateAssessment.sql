CREATE PROCEDURE [dbo].[sp_DeactivateAssessment]
    @AssessmentID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Assessments]
    SET [IsActive] = 0
    WHERE [AssessmentID] = @AssessmentID;
END