USE [HASTANEPROJE]
GO

/****** Object:  Table [dbo].[Tbl_Doktorlar]    Script Date: 9.09.2024 14:17:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Doktorlar](
	[Doktorid] [smallint] IDENTITY(1,1) NOT NULL,
	[Doktorad] [varchar](10) NULL,
	[Doktorsoyad] [varchar](10) NULL,
	[DoktorTc] [char](11) NULL,
	[DoktorÞifre] [varchar](10) NULL,
	[DoktorBranþ] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Doktorid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


