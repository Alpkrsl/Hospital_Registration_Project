USE [HASTANEPROJE]
GO

/****** Object:  Table [dbo].[Tbl_Hastalar]    Script Date: 9.09.2024 14:18:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Hastalar](
	[Hastaid] [smallint] IDENTITY(1,1) NOT NULL,
	[Hastaad] [varchar](10) NULL,
	[Hastasoyad] [varchar](10) NULL,
	[HastaTc] [bigint] NULL,
	[HastaTel] [varchar](15) NULL,
	[Hastaﬁifre] [varchar](10) NULL,
	[HastaCinsiyet] [varchar](5) NULL,
 CONSTRAINT [PK__Tbl_Hast__114D50A3B32EBB17] PRIMARY KEY CLUSTERED 
(
	[Hastaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


