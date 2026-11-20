CREATE PROCEDURE [dbo].[sp_DeactivateSection]
    @SectionID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Sections]
    SET [IsActive] = 0
    WHERE [SectionID] = @SectionID;
END