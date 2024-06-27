 CREATE DATABASE [Contactes]
  GO
USE [Contactes]
GO
/****** Object:  Table [dbo].[Sex]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sex](
	[SexId] [int] NOT NULL,
	[Name] [varchar](10) NULL,
 CONSTRAINT [PK_Sex] PRIMARY KEY CLUSTERED 
(
	[SexId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Age] [int] NULL,
	[IsFavorite] [bit] NOT NULL,
	[BornDate] [date] NULL,
	[DebAmount] [decimal](11, 2) NOT NULL,
	[SexId] [int] NULL,
	[Phone] [varchar](15) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vContacts]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vContacts]
AS
SELECT c.ContactId, c.Name, c.LastName, c.Email, c.Age, c.IsFavorite, c.BornDate, c.DebAmount, c.SexId, c.Phone, s.Name AS SexName
FROM  dbo.Contacts AS c INNER JOIN
         dbo.Sex AS s ON s.SexId = c.SexId
GO
/****** Object:  View [dbo].[vContacts2]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 

CREATE VIEW  [dbo].[vContacts2]
AS
SELECT c.ContactId, c.Name, c.LastName, c.Email, c.Age, c.IsFavorite, c.BornDate, c.DebAmount, c.SexId, c.Phone, s.Name AS SexName
FROM  dbo.Contacts AS c INNER JOIN
         dbo.Sex AS s ON s.SexId = c.SexId
GO
/****** Object:  Table [dbo].[ContactReminders]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactReminders](
	[ContactReminderId] [int] NOT NULL,
	[ContactId] [int] NOT NULL,
	[ReminderId] [int] NOT NULL,
 CONSTRAINT [PK_ContactReminders] PRIMARY KEY CLUSTERED 
(
	[ContactReminderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactsHistories]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactsHistories](
	[ContactsHistory] [int] IDENTITY(1,1) NOT NULL,
	[ContactId] [int] NULL,
	[Name] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](30) NULL,
	[Age] [int] NULL,
	[IsFavorite] [bit] NULL,
	[BornDate] [date] NULL,
	[DebAmount] [decimal](11, 2) NULL,
	[SexId] [int] NULL,
	[Phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactsHistory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reminders]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reminders](
	[ReminderId] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](250) NULL,
 CONSTRAINT [PK_Reminders] PRIMARY KEY CLUSTERED 
(
	[ReminderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (1, N'Juan', N'Alberto', N'alber@email.com', 15, 0, NULL, CAST(0.00 AS Decimal(11, 2)), 1, N'54654654')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (4, N'Carlos', N'Rubio', N'carlos@email.com', 15, 0, NULL, CAST(10000.54 AS Decimal(11, 2)), 1, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (5, N'Marcela', N'Aureliano', N'carlos@email.com', 15, 0, NULL, CAST(111111.54 AS Decimal(11, 2)), 1, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (6, N'Alberto', N'Castro', N'carlos@email.com', 15, 0, NULL, CAST(111111.54 AS Decimal(11, 2)), 1, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (7, N'Aurelio', N'Rubio', N'carlos@email.com', 15, 0, NULL, CAST(0.00 AS Decimal(11, 2)), 2, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (8, N'Carmelo', N'Rubio', N'carlos@email.com', 15, 0, NULL, CAST(0.00 AS Decimal(11, 2)), 2, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (9, N'Carmelo', N'Rubio', N'carlos@email.com', 15, 0, NULL, CAST(0.00 AS Decimal(11, 2)), 2, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (10, N'Carmelo', N'Rubio', N'carlos@email.com', 15, 0, NULL, CAST(150.54 AS Decimal(11, 2)), 2, N'234234234234')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (11, N'Pedro', N'pe', N'pedroperdope@email.com', 0, 0, NULL, CAST(15000.00 AS Decimal(11, 2)), 1, N'151546546')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (12, N'Pedro', N'pe', N'pedroperdope@email.com', 10, 0, NULL, CAST(15000.00 AS Decimal(11, 2)), 1, N'151546546')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (13, N'Pedro', N'pe', N'pedroperdope@email.com', 0, 0, NULL, CAST(15000.00 AS Decimal(11, 2)), 1, N'151546546')
GO
INSERT [dbo].[Contacts] ([ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (14, N'Pedro', N'pe', N'pedroperdope@email.com', 0, 0, NULL, CAST(15000.00 AS Decimal(11, 2)), 1, N'151546546')
GO
SET IDENTITY_INSERT [dbo].[ContactsHistories] ON 
GO
INSERT [dbo].[ContactsHistories] ([ContactsHistory], [ContactId], [Name], [LastName], [Email], [Age], [IsFavorite], [BornDate], [DebAmount], [SexId], [Phone]) VALUES (1, 14, N'Pedro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ContactsHistories] OFF
GO
INSERT [dbo].[Sex] ([SexId], [Name]) VALUES (1, N'M')
GO
INSERT [dbo].[Sex] ([SexId], [Name]) VALUES (2, N'F')
GO
ALTER TABLE [dbo].[ContactReminders]  WITH CHECK ADD  CONSTRAINT [FK_ContactReminders_Contacts] FOREIGN KEY([ContactId])
REFERENCES [dbo].[Contacts] ([ContactId])
GO
ALTER TABLE [dbo].[ContactReminders] CHECK CONSTRAINT [FK_ContactReminders_Contacts]
GO
ALTER TABLE [dbo].[ContactReminders]  WITH CHECK ADD  CONSTRAINT [FK_ContactReminders_Reminders] FOREIGN KEY([ReminderId])
REFERENCES [dbo].[Reminders] ([ReminderId])
GO
ALTER TABLE [dbo].[ContactReminders] CHECK CONSTRAINT [FK_ContactReminders_Reminders]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Sex] FOREIGN KEY([SexId])
REFERENCES [dbo].[Sex] ([SexId])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Sex]
GO
/****** Object:  StoredProcedure [dbo].[AddContact]    Script Date: 6/26/2024 11:49:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE [dbo].[AddContact] 
	@ContactId int,
	@Name varchar(50), 
	@LastName varchar(50), 
	 @Email varchar(30), 
	 @Age int =0, 
	 @BornDate Date = null, 
	 @DebAmount decimal (11,2) = 0, 
	 @SexId int = 1, 
	 @Phone varchar (15), 
	 @Sussess bit = 0 output
AS
BEGIN
	INSERT INTO  Contacts 
           (ContactId  ,Name   ,LastName   ,Email ,Age  ,IsFavorite   ,BornDate
           ,DebAmount  ,SexId  ,Phone)
     VALUES
           (@ContactId , @Name, @LastName, @Email, @Age ,0 ,  @BornDate, 
          @DebAmount , @SexId  , @Phone);
set @Sussess = 1;
END
 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "c"
            Begin Extent = 
               Top = 15
               Left = 96
               Bottom = 324
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 15
               Left = 520
               Bottom = 238
               Right = 848
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vContacts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vContacts'
GO
USE [master]
GO
ALTER DATABASE [Contactes] SET  READ_WRITE 
GO
