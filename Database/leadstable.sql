USE [CRM]
GO

/****** Object:  Table [dbo].[leads]    Script Date: 10/22/2016 6:32:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[leads](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[f_name] [nvarchar](50) NULL,
	[l_name] [nvarchar](50) NULL,
	[office_no] [nvarchar](50) NULL,
	[mob_no] [nvarchar](50) NULL,
	[dept] [nvarchar](50) NULL,
	[website] [nvarchar](max) NULL,
	[p_addstreet] [nvarchar](50) NULL,
	[p_city] [nvarchar](50) NULL,
	[p_state] [nvarchar](50) NULL,
	[p_poscode] [nvarchar](50) NULL,
	[p_country] [nvarchar](50) NULL,
	[a_addstreet] [nvarchar](50) NULL,
	[a_city] [nvarchar](50) NULL,
	[a_state] [nvarchar](50) NULL,
	[a_poscode] [nvarchar](50) NULL,
	[a_country] [nvarchar](50) NULL,
	[a_samepadd] [bit] NULL,
	[email] [nvarchar](50) NULL,
	[profession] [nvarchar](50) NULL,
	[designation] [nvarchar](50) NULL,
	[co_name] [nvarchar](50) NULL,
	[co_add] [nvarchar](max) NULL,
	[co_website] [nvarchar](max) NULL,
	[lead_status] [nvarchar](50) NULL,
	[lead_source] [nvarchar](50) NULL,
	[emp_name] [nvarchar](50) NULL,
	[lead_desc] [nvarchar](50) NULL,
	[do_not_call] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


