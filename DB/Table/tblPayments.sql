CREATE TABLE [dbo].[Payments]
(
    [PaymentID] INT IDENTITY(1,1) NOT NULL,
    [AssessmentID] INT NOT NULL,
    [ReceiptNumber] NVARCHAR(30) NOT NULL,
    [AmountPaid] DECIMAL(10,2) NOT NULL,
    [PaymentMethod] NVARCHAR(30) NOT NULL DEFAULT 'Cash',
    [ReferenceNumber] NVARCHAR(50) NULL,
    [PaymentDate] DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    [ProcessedByUserID] INT NOT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([PaymentID] ASC),
    CONSTRAINT [UQ_Payments_ReceiptNumber] UNIQUE ([ReceiptNumber]),
    CONSTRAINT [FK_Payments_Assessments] FOREIGN KEY ([AssessmentID])
        REFERENCES [dbo].[Assessments]([AssessmentID]),
    CONSTRAINT [FK_Payments_Users] FOREIGN KEY ([ProcessedByUserID])
        REFERENCES [dbo].[Users]([UserID]),
    CONSTRAINT [CK_Payments_PositiveAmount] CHECK ([AmountPaid] > 0)
);