CREATE PROCEDURE [dbo].[sp_AddAssessment]
    @EnrollmentID INT,
    @TuitionFee DECIMAL(10,2),
    @MiscellaneousFee DECIMAL(10,2),
    @OtherFees DECIMAL(10,2),
    @DiscountAmount DECIMAL(10,2),
    @AssessmentDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Verify enrollment is active and enrolled
    IF NOT EXISTS (
        SELECT 1 
        FROM [dbo].[Enrollments]
        WHERE [EnrollmentID] = @EnrollmentID
          AND [IsActive] = 1
          AND [Status] = 'Enrolled'
    )
    BEGIN
        RAISERROR('Invalid or inactive enrollment selected.', 16, 1);
        RETURN;
    END
     
    IF EXISTS (
        SELECT 1 
        FROM [dbo].[Assessments]
        WHERE [EnrollmentID] = @EnrollmentID
          AND [IsActive] = 1
    )
    BEGIN
        RAISERROR('This enrollment already has an active fee assessment. Please update the existing assessment instead.', 16, 1);
        RETURN;
    END

    -- 3. Compute TotalAmount and ensure discount does not exceed gross fees
    DECLARE @GrossTotal DECIMAL(10,2) = ISNULL(@TuitionFee, 0) + ISNULL(@MiscellaneousFee, 0) + ISNULL(@OtherFees, 0);
    DECLARE @Discount DECIMAL(10,2) = ISNULL(@DiscountAmount, 0);

    IF @Discount > @GrossTotal
    BEGIN
        RAISERROR('Discount amount cannot exceed the total gross fees.', 16, 1);
        RETURN;
    END

    DECLARE @TotalAmount DECIMAL(10,2) = @GrossTotal - @Discount;

    INSERT INTO [dbo].[Assessments] (
        [EnrollmentID], [TuitionFee], [MiscellaneousFee],
        [OtherFees], [DiscountAmount], [TotalAmount], [AssessmentDate]
    )
    VALUES (
        @EnrollmentID, @TuitionFee, @MiscellaneousFee,
        @OtherFees, @Discount, @TotalAmount, @AssessmentDate
    );
END