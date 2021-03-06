USE [master]
GO
/****** Object:  Database [KeplerDB]    Script Date: 09/02/2013 00:03:17 ******/
CREATE DATABASE [KeplerDB]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KeplerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KeplerDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [KeplerDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [KeplerDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [KeplerDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [KeplerDB] SET ARITHABORT OFF
GO
ALTER DATABASE [KeplerDB] SET AUTO_CLOSE ON
GO
ALTER DATABASE [KeplerDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [KeplerDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [KeplerDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [KeplerDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [KeplerDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [KeplerDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [KeplerDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [KeplerDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [KeplerDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [KeplerDB] SET  ENABLE_BROKER
GO
ALTER DATABASE [KeplerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [KeplerDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [KeplerDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [KeplerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [KeplerDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [KeplerDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [KeplerDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [KeplerDB] SET  READ_WRITE
GO
ALTER DATABASE [KeplerDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [KeplerDB] SET  MULTI_USER
GO
ALTER DATABASE [KeplerDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [KeplerDB] SET DB_CHAINING OFF
GO
USE [KeplerDB]
GO
/****** Object:  Table [dbo].[RaumschiffAufgabenTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RaumschiffAufgabenTab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Aufgabenbeschreibung] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[RaumschiffAufgabenTab] ON
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (1, N'Militär')
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (2, N'Metrologie')
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (3, N'Wissenschaft')
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (4, N'Land- und Forstwirtschaft')
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (5, N'Navigation')
INSERT [dbo].[RaumschiffAufgabenTab] ([ID], [Aufgabenbeschreibung]) VALUES (6, N'Telekommunikation')
SET IDENTITY_INSERT [dbo].[RaumschiffAufgabenTab] OFF
/****** Object:  Table [dbo].[LaenderTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaenderTab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Laenderkennzeichen] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LaenderTab] ON
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (1, N'Österreich', N'AT')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (2, N'Schweiz', N'CH')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (3, N'China', N'CN')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (4, N'Deutschland', N'D')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (5, N'Europäische Union- ESA', N'EU')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (6, N'Frankreich', N'FR')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (7, N'Groß Britanien', N'GB')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (8, N'Israel', N'IL')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (9, N'Indien', N'IN')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (10, N'Iran', N'IR')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (11, N'Japan', N'JP')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (12, N'Nord Korea', N'KP')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (13, N'Kasachstan', N'KZ')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (14, N'Russland', N'RU')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (15, N'Sowjetunion', N'SU')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (16, N'Ukraine', N'UA')
INSERT [dbo].[LaenderTab] ([ID], [Name], [Laenderkennzeichen]) VALUES (17, N'Vereinigte Staaten von Amerika', N'USA')
SET IDENTITY_INSERT [dbo].[LaenderTab] OFF
/****** Object:  Table [dbo].[HimmelskoerperTypenTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HimmelskoerperTypenTab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HimmelskoerperTypenTab] ON
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (1, N'Galaxie')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (2, N'Galaxiekern')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (3, N'Stern')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (4, N'Planet')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (5, N'Mond')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (6, N'Asteroid')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (7, N'Komet')
INSERT [dbo].[HimmelskoerperTypenTab] ([ID], [Name]) VALUES (8, N'Raumschiff')
SET IDENTITY_INSERT [dbo].[HimmelskoerperTypenTab] OFF
/****** Object:  Table [dbo].[HimmelskoerperTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HimmelskoerperTab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Masse_in_kg] [float] NOT NULL,
	[HimmelskoerperTyp_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HimmelskoerperTab] ON
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (1, N'Sonne', 1.9891E+30, 3)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (2, N'Merkur', 3.3022E+23, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (3, N'Venus', 4.8685E+24, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (4, N'Erde', 5.9736E+24, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (5, N'Mond', 7.3477E+22, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (6, N'Mars', 6.4185E+23, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (7, N'Phobos', 1.072E+16, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (8, N'Deimos', 1.48E+15, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (9, N'Jupiter', 1.8986E+27, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (10, N'Ganymede', 1.4819E+23, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (11, N'Callisto', 1.075E+23, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (12, N'Io', 8.9319E+22, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (13, N'Europa', 4.7998E+22, 5)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (14, N'Saturn', 5.6846E+26, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (15, N'Uranus', 8.681E+25, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (16, N'Neptun', 1.0243E+26, 4)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (17, N'Wostok 1', 4730, 8)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (18, N'Apollo 11', 43898, 8)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (19, N'Shenzhou 5', 7790, 8)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (20, N'Kwangmyŏngsŏng', 100, 8)
INSERT [dbo].[HimmelskoerperTab] ([ID], [Name], [Masse_in_kg], [HimmelskoerperTyp_ID]) VALUES (21, N'Omid', 23, 8)
SET IDENTITY_INSERT [dbo].[HimmelskoerperTab] OFF
/****** Object:  Table [dbo].[UrlSammlungenTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrlSammlungenTab](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kurzbeschreibung] [nvarchar](max) NOT NULL,
	[Url] [nvarchar](max) NOT NULL,
	[UrlTyp] [int] NOT NULL,
	[Himmelskoerper_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UmlaufbahnenTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UmlaufbahnenTab](
	[Laenge_grosse_Halbachse_in_km] [float] NOT NULL,
	[Exzentritzitaet] [float] NOT NULL,
	[Umlaufdauer_in_Tagen] [float] NOT NULL,
	[Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec] [float] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Trabant_ID] [int] NOT NULL,
	[Zentralobjekt_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UmlaufbahnenTab] ON
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (57909036.5522286, 0.20563, 87.969, 47.87, 1, 2, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (108208179.01981892, 0.006756, 224.698, 35.02, 2, 3, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (149597870.70000002, 0.01671123, 365.256363004, 28.78, 3, 4, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (3843399, 0.0549, 27.321582, 1.022, 4, 5, 4)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (227939134.0303053, 0.093315, 686.971, 24.13, 5, 6, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (9377.2, 0.0002, 0.31891023, 2.138, 6, 7, 6)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (23459.999999999996, 0.0002, 1.26244, 1.35, 7, 8, 6)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (778547261.75427687, 0.048775, 4332.59, 13.07, 8, 9, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (1070400, 0.0013, 7.15455296, 10.88, 9, 10, 9)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (1882699.9999999998, 0.007, 16.6890184, 8.204, 10, 11, 9)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (421699.99999999994, 0.0041, 1.769137786, 17.334, 11, 12, 9)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (670900, 0.009, 3.551181, 13.74, 12, 13, 9)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (1433449370.1307759, 0.055723219, 10759.22, 9.69, 13, 14, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (2876679082.5331349, 0.044405586, 30799.095, 6.81, 14, 15, 1)
INSERT [dbo].[UmlaufbahnenTab] ([Laenge_grosse_Halbachse_in_km], [Exzentritzitaet], [Umlaufdauer_in_Tagen], [Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec], [ID], [Trabant_ID], [Zentralobjekt_ID]) VALUES (4553946489.6179886, 0.011214269, 60190.03, 5.43, 15, 16, 1)
SET IDENTITY_INSERT [dbo].[UmlaufbahnenTab] OFF
/****** Object:  Table [dbo].[Sterne_Planeten_MondeTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sterne_Planeten_MondeTab](
	[Aequatordurchmesser_in_km] [float] NOT NULL,
	[Polardurchmesser_in_km] [float] NOT NULL,
	[Oberflaechentemperatur_in_K] [float] NOT NULL,
	[Rotationsperiode_in_Stunden] [float] NOT NULL,
	[Fallbeschleunigung_in_meter_pro_sec] [float] NOT NULL,
	[Rotationsachsenneigung_in_Grad] [float] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Himmelskoerper_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sterne_Planeten_MondeTab] ON
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (696342, 696342, 6000, 601.2, 274, 7.25, 1, 1)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (4878, 4878, 0, 1407.5040000000001, 3.7, 2.11, 2, 2)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (12104, 12104, 0, 5832.432, 8.87, 177.3, 3, 3)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (12742, 12712, 15, 23.93447232, 9.81, 23, 4, 4)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (3476, 3476, 0, 655.71796799999993, 1.6249, 18, 5, 5)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (6792, 6752, -100, 24.622968, 3.711, 25.19, 6, 6)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (22.2, 22.2, 0, 7.65384552, 0.0084, 1.093, 7, 7)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (12.4, 12.4, 0, 30.298560000000002, 0.0039, 0.93, 8, 8)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (142984, 142984, -100, 9.925, 24.79, 3.13, 9, 9)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (5268.2, 5268.2, 0, 171.70927103999998, 1.428, 0.2, 10, 10)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (4820, 4820, 0, 400.53644159999993, 1.235, 0.192, 11, 11)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (3642.6, 3642.6, 0, 42.459306864, 1.796, 0.05, 12, 12)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (3121.6, 3121.6, 0, 85.228344, 1.314, 0.47, 13, 13)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (120536, 108728, -100, 10.57, 10.44, 26.73, 14, 14)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (51118, 49946, -100, -17.23992, 8.69, 97.77, 15, 15)
INSERT [dbo].[Sterne_Planeten_MondeTab] ([Aequatordurchmesser_in_km], [Polardurchmesser_in_km], [Oberflaechentemperatur_in_K], [Rotationsperiode_in_Stunden], [Fallbeschleunigung_in_meter_pro_sec], [Rotationsachsenneigung_in_Grad], [ID], [Himmelskoerper_ID]) VALUES (49528, 48682, -100, 16.1112, 11.15, 28.32, 16, 16)
SET IDENTITY_INSERT [dbo].[Sterne_Planeten_MondeTab] OFF
/****** Object:  Table [dbo].[RaumschiffeTab]    Script Date: 09/02/2013 00:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RaumschiffeTab](
	[Start_der_Mission] [datetime] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Himmelskoerper_ID] [int] NOT NULL,
	[Land_ID] [int] NOT NULL,
	[RaumschiffAufgaben_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[RaumschiffeTab] ON
INSERT [dbo].[RaumschiffeTab] ([Start_der_Mission], [ID], [Himmelskoerper_ID], [Land_ID], [RaumschiffAufgaben_ID]) VALUES (CAST(0x0000576D00000000 AS DateTime), 1, 17, 15, 3)
INSERT [dbo].[RaumschiffeTab] ([Start_der_Mission], [ID], [Himmelskoerper_ID], [Land_ID], [RaumschiffAufgaben_ID]) VALUES (CAST(0x0000633600000000 AS DateTime), 2, 18, 17, 3)
INSERT [dbo].[RaumschiffeTab] ([Start_der_Mission], [ID], [Himmelskoerper_ID], [Land_ID], [RaumschiffAufgaben_ID]) VALUES (CAST(0x0000941300000000 AS DateTime), 3, 19, 3, 3)
INSERT [dbo].[RaumschiffeTab] ([Start_der_Mission], [ID], [Himmelskoerper_ID], [Land_ID], [RaumschiffAufgaben_ID]) VALUES (CAST(0x0000A12500000000 AS DateTime), 4, 20, 12, 3)
INSERT [dbo].[RaumschiffeTab] ([Start_der_Mission], [ID], [Himmelskoerper_ID], [Land_ID], [RaumschiffAufgaben_ID]) VALUES (CAST(0x00009BA400000000 AS DateTime), 5, 21, 10, 6)
SET IDENTITY_INSERT [dbo].[RaumschiffeTab] OFF
/****** Object:  ForeignKey [HimmelskoerperHimmelskoerperTyp]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[HimmelskoerperTab]  WITH CHECK ADD  CONSTRAINT [HimmelskoerperHimmelskoerperTyp] FOREIGN KEY([HimmelskoerperTyp_ID])
REFERENCES [dbo].[HimmelskoerperTypenTab] ([ID])
GO
ALTER TABLE [dbo].[HimmelskoerperTab] CHECK CONSTRAINT [HimmelskoerperHimmelskoerperTyp]
GO
/****** Object:  ForeignKey [HimmelskoerperUrlSammlung]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[UrlSammlungenTab]  WITH CHECK ADD  CONSTRAINT [HimmelskoerperUrlSammlung] FOREIGN KEY([Himmelskoerper_ID])
REFERENCES [dbo].[HimmelskoerperTab] ([ID])
GO
ALTER TABLE [dbo].[UrlSammlungenTab] CHECK CONSTRAINT [HimmelskoerperUrlSammlung]
GO
/****** Object:  ForeignKey [TrabantUmlaufbahn]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[UmlaufbahnenTab]  WITH CHECK ADD  CONSTRAINT [TrabantUmlaufbahn] FOREIGN KEY([Trabant_ID])
REFERENCES [dbo].[HimmelskoerperTab] ([ID])
GO
ALTER TABLE [dbo].[UmlaufbahnenTab] CHECK CONSTRAINT [TrabantUmlaufbahn]
GO
/****** Object:  ForeignKey [ZentralobjektUmlaufbahn]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[UmlaufbahnenTab]  WITH CHECK ADD  CONSTRAINT [ZentralobjektUmlaufbahn] FOREIGN KEY([Zentralobjekt_ID])
REFERENCES [dbo].[HimmelskoerperTab] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UmlaufbahnenTab] CHECK CONSTRAINT [ZentralobjektUmlaufbahn]
GO
/****** Object:  ForeignKey [HimmelskoerperSterne_Planeten_Monde]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[Sterne_Planeten_MondeTab]  WITH CHECK ADD  CONSTRAINT [HimmelskoerperSterne_Planeten_Monde] FOREIGN KEY([Himmelskoerper_ID])
REFERENCES [dbo].[HimmelskoerperTab] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sterne_Planeten_MondeTab] CHECK CONSTRAINT [HimmelskoerperSterne_Planeten_Monde]
GO
/****** Object:  ForeignKey [HimmelskoerperRaumschiffe]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[RaumschiffeTab]  WITH CHECK ADD  CONSTRAINT [HimmelskoerperRaumschiffe] FOREIGN KEY([Himmelskoerper_ID])
REFERENCES [dbo].[HimmelskoerperTab] ([ID])
GO
ALTER TABLE [dbo].[RaumschiffeTab] CHECK CONSTRAINT [HimmelskoerperRaumschiffe]
GO
/****** Object:  ForeignKey [LandRaumschiffe]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[RaumschiffeTab]  WITH CHECK ADD  CONSTRAINT [LandRaumschiffe] FOREIGN KEY([Land_ID])
REFERENCES [dbo].[LaenderTab] ([ID])
GO
ALTER TABLE [dbo].[RaumschiffeTab] CHECK CONSTRAINT [LandRaumschiffe]
GO
/****** Object:  ForeignKey [RaumschiffAufgabenRaumschiffe]    Script Date: 09/02/2013 00:03:18 ******/
ALTER TABLE [dbo].[RaumschiffeTab]  WITH CHECK ADD  CONSTRAINT [RaumschiffAufgabenRaumschiffe] FOREIGN KEY([RaumschiffAufgaben_ID])
REFERENCES [dbo].[RaumschiffAufgabenTab] ([ID])
GO
ALTER TABLE [dbo].[RaumschiffeTab] CHECK CONSTRAINT [RaumschiffAufgabenRaumschiffe]
GO
