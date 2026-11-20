CREATE TABLE [dbo].[Assessments]
(
    [AssessmentID] INT IDENTITY(1,1) NOT NULL,
    [EnrollmentID] INT NOT NULL,
    [TuitionFee] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [MiscellaneousFee] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [OtherFees] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [DiscountAmount] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [TotalAmount] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [AssessmentDate] DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    [IsActive] BIT NOT NULL DEFAULT 1,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Assessments] PRIMARY KEY CLUSTERED ([AssessmentID] ASC),
    CONSTRAINT [FK_Assessments_Enrollments] FOREIGN KEY ([EnrollmentID])
        REFERENCES [dbo].[Enrollments]([EnrollmentID]),
    CONSTRAINT [CK_Assessments_NonNegative] CHECK (
        [TuitionFee] >= 0 
        AND [MiscellaneousFee] >= 0 
        AND [OtherFees] >= 0 
        AND [DiscountAmount] >= 0 
        AND [TotalAmount] >= 0
    )
);