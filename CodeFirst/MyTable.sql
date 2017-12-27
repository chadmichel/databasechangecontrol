-- This project has a very simple structure, and only a single table. We will 
-- use this table / database to show many migration examples.

CREATE TABLE [dbo].[TimeLogItems](
	[ID] [int] NOT NULL identity(1,1),
	
	[Name] [nvarchar](max) NULL,
	[User] [nvarchar](max) NULL,
	[Project] [nvarchar](max) NULL,
	[Minutes] decimal NOT NULL,
	[Date] [datetime] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Week] [int] NOT NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TimeLogItems] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
