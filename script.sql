USE [Deneme]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CountryId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currencies]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currencies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ShortName] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Currencies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incoterms]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incoterms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Incoterms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modes]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Modes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovementTypes]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovementTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_MovementTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModeId] [int] NOT NULL,
	[MovementTypeId] [int] NOT NULL,
	[IncotermId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[PackageTypeId] [int] NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[LengthUnitId] [int] NOT NULL,
	[WeightUnitId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationClaim]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_OperationClaim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackageTypes]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackageTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_PackageTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOperationClaim]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OperationClaimId] [int] NOT NULL,
 CONSTRAINT [PK_UserOperationClaim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.01.2024 02:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'İstanbul', 1, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'İzmir', 1, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'New York', 2, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (4, N'Los Angeles', 2, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (5, N'Miami', 2, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (6, N'Minnesota', 2, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (7, N'Beijingi', 3, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (8, N'Shanghai', 3, CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'Turkey', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Countries] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'USA', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Countries] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'China', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Currencies] ON 

INSERT [dbo].[Currencies] ([Id], [ShortName], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'USD', N'US Dollar', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Currencies] ([Id], [ShortName], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'CNY', N'Chinese Yuan', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Currencies] ([Id], [ShortName], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'TRY', N'Turkish Lira', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Currencies] OFF
GO
SET IDENTITY_INSERT [dbo].[Incoterms] ON 

INSERT [dbo].[Incoterms] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'Delivered Duty Paid (DDP)', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Incoterms] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'Delivered At Place (DAT)', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Incoterms] OFF
GO
SET IDENTITY_INSERT [dbo].[Modes] ON 

INSERT [dbo].[Modes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'LCL', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Modes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'FCL', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Modes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'Air', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Modes] OFF
GO
SET IDENTITY_INSERT [dbo].[MovementTypes] ON 

INSERT [dbo].[MovementTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'Door to Door', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[MovementTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'Port to Door', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[MovementTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'Door to Port', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[MovementTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (4, N'Port to Port', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[MovementTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Offers] ON 

INSERT [dbo].[Offers] ([Id], [ModeId], [MovementTypeId], [IncotermId], [CountryId], [CityId], [PackageTypeId], [CurrencyId], [LengthUnitId], [WeightUnitId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, 1, 1, 2, 2, 6, 2, 1, 2, 2, CAST(N'2024-01-23T22:07:39.0340000' AS DateTime2), CAST(N'2024-01-24T01:07:39.0411933' AS DateTime2), 0)
INSERT [dbo].[Offers] ([Id], [ModeId], [MovementTypeId], [IncotermId], [CountryId], [CityId], [PackageTypeId], [CurrencyId], [LengthUnitId], [WeightUnitId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (4, 1, 2, 2, 2, 5, 2, 2, 2, 2, CAST(N'2024-01-23T22:12:17.4760000' AS DateTime2), CAST(N'2024-01-24T01:12:17.4823149' AS DateTime2), 0)
INSERT [dbo].[Offers] ([Id], [ModeId], [MovementTypeId], [IncotermId], [CountryId], [CityId], [PackageTypeId], [CurrencyId], [LengthUnitId], [WeightUnitId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (5, 2, 1, 2, 3, 4, 1, 1, 2, 1, CAST(N'2024-01-23T22:13:21.8360000' AS DateTime2), CAST(N'2024-01-24T01:13:21.8417321' AS DateTime2), 0)
INSERT [dbo].[Offers] ([Id], [ModeId], [MovementTypeId], [IncotermId], [CountryId], [CityId], [PackageTypeId], [CurrencyId], [LengthUnitId], [WeightUnitId], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (6, 1, 1, 1, 2, 6, 1, 1, 1, 1, CAST(N'2024-01-23T22:53:57.7270000' AS DateTime2), CAST(N'2024-01-24T01:53:57.7341486' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Offers] OFF
GO
SET IDENTITY_INSERT [dbo].[PackageTypes] ON 

INSERT [dbo].[PackageTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (1, N'Pallets', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[PackageTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (2, N'Boxes', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[PackageTypes] ([Id], [Name], [CreatedDate], [UpdatedDate], [isDeleted]) VALUES (3, N'Cartons', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[PackageTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [PasswordSalt], [PasswordHash], [Status]) VALUES (6, N'Avni', N'ŞEN', N'admin@admin.com', 0x061E1D9B2C9BD8DF78CFD67654EFFF8A1CE9ECCE7094348948549AEBFAD727784BA1D637F2D3D1FECD18F801A111A1CA9E92AB3713FDA255E27F47A5EA63888087976C64EC69CE0D745366C4DA8311802625B691170DCFF8FEBBAA2ED0AEB828EF5E3307C004D2A9F2D3EF7D409373D3479D43F56B8BE038534450E2AF703E38, 0x7DE7E047AE4DD184569D785DFC8766816FDF935190BCDA50CAE76C56E22447878829DCD67D89A27A6B1239E019FED41C8D71BB9CD552E78C9D24716BBAB28667, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
