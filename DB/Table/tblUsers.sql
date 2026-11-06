CREATE TABLE [dbo].[Users]
(
    [UserID] INT IDENTITY(1,1) NOT NULL,
    [Username] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(255) NOT NULL, 
    [IsAdmin] BIT NOT NULL DEFAULT 0,
    [DateCreated] DATETIME2 NOT NULL DEFAULT GETDATE(),

    -- Constraints
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [UQ_Users_Username] UNIQUE ([Username])
)