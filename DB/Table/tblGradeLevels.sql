CREATE TABLE [dbo].[GradeLevels]
(
    [GradeLevelID] INT IDENTITY(1,1) NOT NULL,
    [GradeLevelName] NVARCHAR(50) NOT NULL,
    [TuitionFee] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [MiscellaneousFee] DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    [IsActive] BIT NOT NULL DEFAULT 1,

    CONSTRAINT [PK_GradeLevels] PRIMARY KEY CLUSTERED ([GradeLevelID] ASC)
);