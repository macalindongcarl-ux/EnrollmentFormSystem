CREATE TABLE [dbo].[Sections]
(
    [SectionID] INT IDENTITY(1,1) NOT NULL,
    [SectionName] NVARCHAR(50) NOT NULL,
    [GradeLevelID] INT NOT NULL,
    [SchoolYear] NVARCHAR(20) NOT NULL,
    [Adviser] NVARCHAR(100) NULL,
    [MaxCapacity] INT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED ([SectionID] ASC),
    CONSTRAINT [FK_Sections_GradeLevels] FOREIGN KEY ([GradeLevelID]) 
        REFERENCES [dbo].[GradeLevels]([GradeLevelID]),
    CONSTRAINT [UQ_Sections_Name_Grade_SY] UNIQUE ([SectionName], [GradeLevelID], [SchoolYear]),
    CONSTRAINT [CK_Sections_MaxCapacity] CHECK ([MaxCapacity] IS NULL OR [MaxCapacity] > 0)
);