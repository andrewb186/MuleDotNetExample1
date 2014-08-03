USE [muleNetDBExample001]
GO
/****** Object:  Table [dbo].[PersonDetails]    Script Date: 08/03/2014 11:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](25) NOT NULL,
	[surname] [varchar](25) NOT NULL,
	[age] [int] NULL,
	[telephone] [varchar](10) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_PersonDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 08/03/2014 11:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Credentials](
	[personID] [int] NOT NULL,
	[username] [varchar](25) NOT NULL,
	[password] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_PersonDetails_age]    Script Date: 08/03/2014 11:22:43 ******/
ALTER TABLE [dbo].[PersonDetails] ADD  CONSTRAINT [DF_PersonDetails_age]  DEFAULT ((0)) FOR [age]
GO
/****** Object:  ForeignKey [FK_Credentials_PersonDetails]    Script Date: 08/03/2014 11:22:43 ******/
ALTER TABLE [dbo].[Credentials]  WITH CHECK ADD  CONSTRAINT [FK_Credentials_PersonDetails] FOREIGN KEY([personID])
REFERENCES [dbo].[PersonDetails] ([id])
GO
ALTER TABLE [dbo].[Credentials] CHECK CONSTRAINT [FK_Credentials_PersonDetails]
GO
