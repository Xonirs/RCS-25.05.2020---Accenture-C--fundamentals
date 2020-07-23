USE [CompanyInventory]
GO

/****** Object:  Table [dbo].[InventoryItems]    Script Date: 23.07.2020 18:56:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InventoryItems](
	[Id] [int] NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Quantity] [int] NULL,
	[Color] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

