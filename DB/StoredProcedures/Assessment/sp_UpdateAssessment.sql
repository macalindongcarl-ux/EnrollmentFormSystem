CREATE PROCEDURE [dbo].[sp_UpdateAssessment]
    @AssessmentID INT,
    @EnrollmentID INT,
    @TuitionFee DECIMAL(10,2),
    @MiscellaneousFee DECIMAL(10,2),
    @OtherFees DECIMAL(10,2),
    @DiscountAmount DECIMAL(10,2),
    @AssessmentDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Assessments]
        WHERE [EnrollmentID] = @EnrollmentID
          AND [AssessmentID] <> @AssessmentID
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('Another active assessment already exists for this enrollment.', 16, 1);
        RETURN;
    END

    DECLARE @GrossTotal DECIMAL(10,2) = ISNULL(@TuitionFee, 0) + ISNULL(@MiscellaneousFee, 0) + ISNULL(@OtherFees, 0);
    DECLARE @Discount DECIMAL(10,2) = ISNULL(@DiscountAmount, 0);

    IF @Discount > @GrossTotal
    BEGIN
        RAISERROR('Discount amount cannot exceed the total gross fees.', 16, 1);
        RETURN;
    END

    DECLARE @TotalAmount DECIMAL(10,2) = @GrossTotal - @Discount;

    UPDATE [dbo].[Assessments]
    SET 
        [EnrollmentID] = @EnrollmentID,
        [TuitionFee] = @TuitionFee,
        [MiscellaneousFee] = @MiscellaneousFee,
        [OtherFees] = @OtherFees,
        [DiscountAmount] = @Discount,
        [TotalAmount] = @TotalAmount,
        [AssessmentDate] = @AssessmentDate
    WHERE 
        [AssessmentID] = @AssessmentID;
END