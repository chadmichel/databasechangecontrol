CREATE TABLE [dbo].[TimeLogItems] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [User]        NVARCHAR (MAX)  NULL,
    [Project]     NVARCHAR (MAX)  NULL,
    [Minutes]     DECIMAL (18, 2) NOT NULL,
    [Date]        DATETIME        NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Week]        INT             NOT NULL,
    [Year]        INT             NOT NULL,
    [ExternalId]  NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.TimeLogItems] PRIMARY KEY CLUSTERED ([ID] ASC)
);

