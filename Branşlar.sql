USE [HASTANEPROJE]
GO

/****** Object:  Table [dbo].[Tbl_Bran�lar]    Script Date: 9.09.2024 14:16:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Bran�lar](
	[Bran�id] [smallint] IDENTITY(1,1) NOT NULL,
	[Bran�ad] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Bran�id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


