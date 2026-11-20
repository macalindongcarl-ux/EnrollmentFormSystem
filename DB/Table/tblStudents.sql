CREATE TABLE [dbo].[Students]
(
    [StudentID] INT IDENTITY(1,1) NOT NULL,
    [StudentNumber] NVARCHAR(30) NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL,
    [MiddleName] NVARCHAR(50) NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [DateOfBirth] DATE NOT NULL,
    [Gender] NVARCHAR(15) NOT NULL,
    [Address] NVARCHAR(255) NOT NULL,
    [ContactNumber] NVARCHAR(20) NULL,
    [Email] NVARCHAR(100) NULL,
    [GuardianName] NVARCHAR(100) NOT NULL,
    [GuardianContact] NVARCHAR(20) NOT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([StudentID] ASC),
    CONSTRAINT [UQ_Students_StudentNumber] UNIQUE ([StudentNumber]),
    CONSTRAINT [CK_Students_Gender] CHECK ([Gender] IN ('Male', 'Female'))
);