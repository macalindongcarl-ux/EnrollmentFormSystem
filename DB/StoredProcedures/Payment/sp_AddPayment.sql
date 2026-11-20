CREATE PROCEDURE [dbo].[sp_AddPayment]
    @AssessmentID INT,
    @AmountPaid DECIMAL(10,2),
    @PaymentMethod NVARCHAR(30),
    @ReferenceNumber NVARCHAR(50) = NULL,
    @PaymentDate DATE,
    @ProcessedByUserID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @AmountPaid <= 0
    BEGIN
        RAISERROR('Payment amount must be greater than 0.00.', 16, 1);
        RETURN;
    END

    -- 1. Check active assessment and current remaining balance
    DECLARE @TotalAssessed DECIMAL(10,2);
    DECLARE @TotalPaid DECIMAL(10,2);

    SELECT @TotalAssessed = [TotalAmount]
    FROM [dbo].[Assessments]
    WHERE [AssessmentID] = @AssessmentID
      AND [IsActive] = 1;

    IF @TotalAssessed IS NULL
    BEGIN
        RAISERROR('Invalid or inactive assessment selected.', 16, 1);
        RETURN;
    END

    SELECT @TotalPaid = ISNULL(SUM([AmountPaid]), 0.00)
    FROM [dbo].[Payments]
    WHERE [AssessmentID] = @AssessmentID
      AND [IsActive] = 1;

    DECLARE @RemainingBalance DECIMAL(10,2) = @TotalAssessed - @TotalPaid;

    IF @RemainingBalance <= 0
    BEGIN
        RAISERROR('This student account is already fully paid.', 16, 1);
        RETURN;
    END

    IF @AmountPaid > @RemainingBalance
    BEGIN
        RAISERROR('Payment amount cannot exceed the remaining balance.', 16, 1);
        RETURN;
    END

    -- 2. Generate sequential Official Receipt Number (e.g., OR-2026-0001)
    DECLARE @NextId INT = ISNULL((SELECT MAX([PaymentID]) FROM [dbo].[Payments]), 0) + 1;
    DECLARE @YearPart VARCHAR(4) = CAST(YEAR(@PaymentDate) AS VARCHAR(4));
    DECLARE @GeneratedOR NVARCHAR(30) = 'OR-' + @YearPart + '-' + RIGHT('0000' + CAST(@NextId AS VARCHAR(10)), 4);

    INSERT INTO [dbo].[Payments] (
        [AssessmentID], [ReceiptNumber], [AmountPaid],
        [PaymentMethod], [ReferenceNumber], [PaymentDate], [ProcessedByUserID]
    )
    VALUES (
        @AssessmentID, @GeneratedOR, @AmountPaid,
        @PaymentMethod, NULLIF(LTRIM(RTRIM(@ReferenceNumber)), ''), @PaymentDate, @ProcessedByUserID
    );

    SELECT @GeneratedOR AS [ReceiptNumber];
END