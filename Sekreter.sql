USE [HASTANEPROJE]
GO

/****** Object:  Table [dbo].[Tbl_Sekreter]    Script Date: 9.09.2024 14:19:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Sekreter](
	[Sekreteradsoyad] [varchar](20) NULL,
	[SekreterTc] [char](11) NULL,
	[Sekreterﬁifre] [varchar](10) NULL,
	[Sekreter›d] [smallint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sekreter›d] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


