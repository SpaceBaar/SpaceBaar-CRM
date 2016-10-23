USE [CRM]
GO

/****** Object:  Table [dbo].[Contacts]    Script Date: 10/22/2016 6:30:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contacts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](50) NULL,
	[email] [nvarchar](max) NULL,
	[street] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[state] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[country] [nvarchar](50) NULL,
	[profession] [nvarchar](50) NULL,
	[designation] [nvarchar](50) NULL,
	[cname] [nvarchar](50) NULL,
	[cadd] [nvarchar](50) NULL,
	[website] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[altstreet] [nvarchar](50) NULL,
	[altcity] [nvarchar](50) NULL,
	[altstate] [nvarchar](50) NULL,
	[altcode] [nvarchar](50) NULL,
	[altcountry] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


