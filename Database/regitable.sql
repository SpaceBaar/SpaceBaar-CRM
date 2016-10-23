USE [CRM]
GO

/****** Object:  Table [dbo].[regi]    Script Date: 10/22/2016 6:32:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[regi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[dob] [date] NULL,
	[add1] [nvarchar](50) NULL,
	[add2] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[state] [nvarchar](50) NULL,
	[country] [nvarchar](50) NULL,
	[email] [nvarchar](max) NULL,
	[mobile] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[c_name] [nvarchar](50) NULL,
	[c_contact] [nvarchar](50) NULL,
	[c_add1] [nvarchar](50) NULL,
	[c_add2] [nvarchar](50) NULL,
	[c_city] [nvarchar](50) NULL,
	[c_state] [nvarchar](50) NULL,
	[c_email] [nvarchar](max) NULL,
	[website] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


