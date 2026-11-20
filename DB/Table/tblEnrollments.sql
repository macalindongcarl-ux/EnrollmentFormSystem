CREATE TABLE [dbo].[Enrollments]
(
    [EnrollmentID] INT IDENTITY(1,1) NOT NULL,
    [StudentID] INT NOT NULL,
    [GradeLevelID] INT NOT NULL,
    [SectionID] INT NOT NULL,
    [SchoolYear] NVARCHAR(20) NOT NULL,
    [EnrollmentDate] DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    [Status] NVARCHAR(20) NOT NULL DEFAULT 'Enrolled',
    [IsActive] BIT NOT NULL DEFAULT 1,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_Enrollments_Students] FOREIGN KEY ([StudentID])
        REFERENCES [dbo].[Students]([StudentID]),
    CONSTRAINT [FK_Enrollments_GradeLevels] FOREIGN KEY ([GradeLevelID])
        REFERENCES [dbo].[GradeLevels]([GradeLevelID]),
    CONSTRAINT [FK_Enrollments_Sections] FOREIGN KEY ([SectionID])
        REFERENCES [dbo].[Sections]([SectionID]),
    CONSTRAINT [CK_Enrollments_Status] CHECK ([Status] IN ('Enrolled', 'Dropped'))
);