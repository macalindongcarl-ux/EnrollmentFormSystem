CREATE PROCEDURE [dbo].[sp_DeactivatePayment]
    @PaymentID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Payments]
    SET [IsActive] = 0
    WHERE [PaymentID] = @PaymentID;
END