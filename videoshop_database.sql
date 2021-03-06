USE [master]
GO
/****** Object:  Database [VideoShop]    Script Date: 8/29/2020 6:39:00 PM ******/
CREATE DATABASE [VideoShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoShop', FILENAME = N'G:\Университет\3 курс\2 семестър\TSPProject\VideoShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoShop_log', FILENAME = N'G:\Университет\3 курс\2 семестър\TSPProject\VideoShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VideoShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoShop] SET RECOVERY FULL 
GO
ALTER DATABASE [VideoShop] SET  MULTI_USER 
GO
ALTER DATABASE [VideoShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VideoShop', N'ON'
GO
ALTER DATABASE [VideoShop] SET QUERY_STORE = OFF
GO
USE [VideoShop]
GO
/****** Object:  Table [dbo].[CITIES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITIES](
	[CITY_ID] [int] IDENTITY(1,1) NOT NULL,
	[CITY_NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_CITIIES_ID] PRIMARY KEY CLUSTERED 
(
	[CITY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COUNTRIES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COUNTRIES](
	[COUNTRY_ID] [int] IDENTITY(1,1) NOT NULL,
	[COUNTRY_NAME] [char](256) NOT NULL,
 CONSTRAINT [PK_COUNTRIES_ID] PRIMARY KEY CLUSTERED 
(
	[COUNTRY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[EMP_ID] [int] IDENTITY(1,1) NOT NULL,
	[EMP_FNAME] [nvarchar](128) NOT NULL,
	[EMP_LNAME] [nvarchar](128) NOT NULL,
	[EMP_SALARY] [int] NOT NULL,
	[EMP_PH_N] [nvarchar](16) NOT NULL,
	[POSITION_ID] [int] NOT NULL,
	[CITY_ID] [int] NOT NULL,
 CONSTRAINT [PK_EMPLOYEES_ID] PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FILM_LIBRARY]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FILM_LIBRARY](
	[FILM_ID] [int] NOT NULL,
	[USER_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FILMS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FILMS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FILM_PRODUCER] [nvarchar](256) NOT NULL,
	[FILM_LEADING] [nvarchar](256) NOT NULL,
	[FILM_NAME] [nvarchar](128) NOT NULL,
	[GENRE_ID] [int] NOT NULL,
	[FILM_YEAR] [char](16) NULL,
 CONSTRAINT [PK_FILMS_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GENRES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GENRES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GENRE_NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_GENRES_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POSITIONS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POSITIONS](
	[POS_ID] [int] IDENTITY(1,1) NOT NULL,
	[POSITION_DESC] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_POS_ID] PRIMARY KEY CLUSTERED 
(
	[POS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RENT]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RENT](
	[RENT_ID] [int] IDENTITY(1,1) NOT NULL,
	[RENTED_USER_ID] [int] NOT NULL,
	[FILM_ID] [int] NOT NULL,
	[RENTED_FROM_DATE] [date] NOT NULL,
	[RENTED_RETURN_DATE] [date] NOT NULL,
 CONSTRAINT [PK_RENTED_ID] PRIMARY KEY CLUSTERED 
(
	[RENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RENTED_STOCKS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RENTED_STOCKS](
	[FILMS_ID] [int] NOT NULL,
	[RENTED_FILMS_ID] [int] NOT NULL,
	[QUANTITY_RENTED] [int] NOT NULL,
 CONSTRAINT [PK_RENTED_STOCKS] PRIMARY KEY CLUSTERED 
(
	[FILMS_ID] ASC,
	[RENTED_FILMS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE](
	[SALE_ID] [int] IDENTITY(1,1) NOT NULL,
	[SALE_DATE] [date] NOT NULL,
	[EMPLOYEE_ID] [int] NOT NULL,
	[SALE_USER_ID] [int] NOT NULL,
 CONSTRAINT [PK_SALE_ID] PRIMARY KEY CLUSTERED 
(
	[SALE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERIES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERIES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SERIES_PRODUCER] [nvarchar](256) NOT NULL,
	[SERIES_LEADING] [nvarchar](256) NOT NULL,
	[SERIES_NAME] [nvarchar](256) NOT NULL,
	[SERIES_SEASON] [int] NOT NULL,
	[GENRE_ID] [int] NOT NULL,
	[SERIES_YEAR] [char](16) NOT NULL,
 CONSTRAINT [PK_SERIES_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERIES_LIBRARY]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERIES_LIBRARY](
	[SERIES_ID] [int] NOT NULL,
	[USER_ID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SERVICE_NAME] [nvarchar](128) NOT NULL,
	[SERVICE_PRICE] [float] NOT NULL,
 CONSTRAINT [PK_SERVICES_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOLD_STOCKS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOLD_STOCKS](
	[STORAGE_FILM_ID] [int] NOT NULL,
	[STORAGE_PRICE] [float] NOT NULL,
	[QUANTITY_SOLD] [int] NOT NULL,
	[SOLD_SALE_ID] [int] NOT NULL,
 CONSTRAINT [PK_SOLD_STOCKS_ID] PRIMARY KEY CLUSTERED 
(
	[STORAGE_FILM_ID] ASC,
	[STORAGE_PRICE] ASC,
	[SOLD_SALE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STORAGE]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STORAGE](
	[FILM_ID] [int] NOT NULL,
	[FILM_PRICE] [float] NOT NULL,
	[STORAGE_QUANTITUY] [int] NOT NULL,
	[TYPE_ID] [int] NULL,
 CONSTRAINT [PK_STORAGE_ID] PRIMARY KEY CLUSTERED 
(
	[FILM_ID] ASC,
	[FILM_PRICE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBSCRIPTIONS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBSCRIPTIONS](
	[SUBS_ID] [int] IDENTITY(1,1) NOT NULL,
	[SUBS_USER_ID] [int] NOT NULL,
	[SERVICES_ID] [int] NOT NULL,
	[SUBS_START_DATE] [date] NOT NULL,
	[SUBS_END_DATE] [date] NOT NULL,
 CONSTRAINT [PK_SUBSCRIPTIONS_ID] PRIMARY KEY CLUSTERED 
(
	[SUBS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPES]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE_NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_TYPES_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[USER_ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_USERNAME] [char](256) NOT NULL,
	[USER_PASSWORD] [char](256) NOT NULL,
	[USER_EMAIL] [char](512) NOT NULL,
	[COUNTRY_ID] [int] NOT NULL,
 CONSTRAINT [PK_USERS_ID] PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CITIES] ON 

INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (1, N'Варна')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (2, N'София')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (3, N'Добрич')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (4, N'Бургас')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (5, N'Шумен')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (7, N'Пловдив')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (8, N'Разград')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (9, N'Букурещ')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (14, N'Стара Загора')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (15, N'Русе')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (16, N'Силистра')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (17, N'Видин')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (18, N'Велико Търново')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (19, N'Хасково')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (20, N'Ямбол')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (21, N'Сандански')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (25, N'Монтана')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (26, N'Ловеч')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (27, N'Сливен')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (28, N'Лондон')
INSERT [dbo].[CITIES] ([CITY_ID], [CITY_NAME]) VALUES (29, N'dsadsa')
SET IDENTITY_INSERT [dbo].[CITIES] OFF
SET IDENTITY_INSERT [dbo].[COUNTRIES] ON 

INSERT [dbo].[COUNTRIES] ([COUNTRY_ID], [COUNTRY_NAME]) VALUES (1, N'Bulgaria                                                                                                                                                                                                                                                        ')
SET IDENTITY_INSERT [dbo].[COUNTRIES] OFF
SET IDENTITY_INSERT [dbo].[EMPLOYEES] ON 

INSERT [dbo].[EMPLOYEES] ([EMP_ID], [EMP_FNAME], [EMP_LNAME], [EMP_SALARY], [EMP_PH_N], [POSITION_ID], [CITY_ID]) VALUES (1, N'Кирил', N'Атанасов', 850, N'0895748801', 2, 1)
INSERT [dbo].[EMPLOYEES] ([EMP_ID], [EMP_FNAME], [EMP_LNAME], [EMP_SALARY], [EMP_PH_N], [POSITION_ID], [CITY_ID]) VALUES (2, N'Георги', N'Атанасов', 999, N'0895747474', 3, 14)
INSERT [dbo].[EMPLOYEES] ([EMP_ID], [EMP_FNAME], [EMP_LNAME], [EMP_SALARY], [EMP_PH_N], [POSITION_ID], [CITY_ID]) VALUES (3, N'Георги', N'Стоянов', 1050, N'087757575', 2, 3)
INSERT [dbo].[EMPLOYEES] ([EMP_ID], [EMP_FNAME], [EMP_LNAME], [EMP_SALARY], [EMP_PH_N], [POSITION_ID], [CITY_ID]) VALUES (4, N'Александър', N'Киров', 1500, N'07845454', 3, 2)
INSERT [dbo].[EMPLOYEES] ([EMP_ID], [EMP_FNAME], [EMP_LNAME], [EMP_SALARY], [EMP_PH_N], [POSITION_ID], [CITY_ID]) VALUES (5, N'асен', N'асенов', 850, N'1234567890', 5, 14)
SET IDENTITY_INSERT [dbo].[EMPLOYEES] OFF
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (4, 12)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (4, 10)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (14, 9)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (10, 13)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (6, 11)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (8, 11)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (13, 11)
INSERT [dbo].[FILM_LIBRARY] ([FILM_ID], [USER_ID]) VALUES (15, 11)
SET IDENTITY_INSERT [dbo].[FILMS] ON 

INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (1, N'Джон Хюс', N'Маколи Кълкин', N'Сам Вкъщи', 9, N'1990            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (4, N'Джон Мактиърън', N'Брус Уилис', N'Умирай Трудно 3', 6, N'1996            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (5, N'Лен Уайзмън', N'Брус Уилис', N'Умирай Трудно 4', 6, N'2007            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (6, N'Джон Жюз', N'Маколи Кълкин', N'Сам Вкъщи 2', 9, N'1992            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (7, N'Джон  Хюз', N'Алекс Линц', N'Сам Вкъщи 3', 9, N'1997            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (8, N'Митч Ейнджъл', N'Джейсън Бег', N'Сам Вкъщи 4', 9, N'2002            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (9, N'Куентин Тарантино', N'Джейми Фокс', N'Джанго без окови', 17, N'2012            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (10, N'Дъглас Уик', N'Джейк Джиленхол', N'Снайперисти', 3, N'2005            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (11, N'Нира Парк', N'Ансел Елгорт', N'Зад Волана', 6, N'2017            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (13, N'Джон Мактиърън', N'Брус Уилис', N'Умирай Трудно 2', 6, N'1990            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (14, N'Алехандро Иратиру', N'Леонардо ди Каприо', N'The Revenant', 17, N'2015            ')
INSERT [dbo].[FILMS] ([ID], [FILM_PRODUCER], [FILM_LEADING], [FILM_NAME], [GENRE_ID], [FILM_YEAR]) VALUES (15, N'господин', N'123', N'123', 12, N'2010            ')
SET IDENTITY_INSERT [dbo].[FILMS] OFF
SET IDENTITY_INSERT [dbo].[GENRES] ON 

INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (1, N'Анимация')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (2, N'Биографичен ')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (3, N'Военен')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (4, N'Документален')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (5, N'Драма')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (6, N'Екшън')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (7, N'Еротичен')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (8, N'Исторически')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (9, N'Комедия')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (10, N'Мюзикъл')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (11, N'Научна фантастика')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (12, N'Приключенски')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (13, N'Романс')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (14, N'Трилър')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (15, N'Ужаси')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (16, N'Фентъзи')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (17, N'Уестърн')
INSERT [dbo].[GENRES] ([ID], [GENRE_NAME]) VALUES (18, N'Научен')
SET IDENTITY_INSERT [dbo].[GENRES] OFF
SET IDENTITY_INSERT [dbo].[POSITIONS] ON 

INSERT [dbo].[POSITIONS] ([POS_ID], [POSITION_DESC]) VALUES (1, N'Управител')
INSERT [dbo].[POSITIONS] ([POS_ID], [POSITION_DESC]) VALUES (2, N'Продавач')
INSERT [dbo].[POSITIONS] ([POS_ID], [POSITION_DESC]) VALUES (3, N'Мениджър')
INSERT [dbo].[POSITIONS] ([POS_ID], [POSITION_DESC]) VALUES (4, N'Администратор')
INSERT [dbo].[POSITIONS] ([POS_ID], [POSITION_DESC]) VALUES (5, N'Чистач')
SET IDENTITY_INSERT [dbo].[POSITIONS] OFF
SET IDENTITY_INSERT [dbo].[RENT] ON 

INSERT [dbo].[RENT] ([RENT_ID], [RENTED_USER_ID], [FILM_ID], [RENTED_FROM_DATE], [RENTED_RETURN_DATE]) VALUES (1, 1, 1, CAST(N'2020-02-14' AS Date), CAST(N'2020-02-22' AS Date))
SET IDENTITY_INSERT [dbo].[RENT] OFF
SET IDENTITY_INSERT [dbo].[SALE] ON 

INSERT [dbo].[SALE] ([SALE_ID], [SALE_DATE], [EMPLOYEE_ID], [SALE_USER_ID]) VALUES (1, CAST(N'2020-02-16' AS Date), 1, 1)
SET IDENTITY_INSERT [dbo].[SALE] OFF
SET IDENTITY_INSERT [dbo].[SERIES] ON 

INSERT [dbo].[SERIES] ([ID], [SERIES_PRODUCER], [SERIES_LEADING], [SERIES_NAME], [SERIES_SEASON], [GENRE_ID], [SERIES_YEAR]) VALUES (1, N'Стив Лайтфут', N'Джон Бернтол', N'Наказателят', 1, 6, N'2017            ')
INSERT [dbo].[SERIES] ([ID], [SERIES_PRODUCER], [SERIES_LEADING], [SERIES_NAME], [SERIES_SEASON], [GENRE_ID], [SERIES_YEAR]) VALUES (2, N'Братя Дуфлер', N'Уинона Райдър', N'Stranger Things', 2, 16, N'2016            ')
INSERT [dbo].[SERIES] ([ID], [SERIES_PRODUCER], [SERIES_LEADING], [SERIES_NAME], [SERIES_SEASON], [GENRE_ID], [SERIES_YEAR]) VALUES (3, N'господин', N'123', N'123', 4, 5, N'2018            ')
SET IDENTITY_INSERT [dbo].[SERIES] OFF
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (1, 10)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (1, 11)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (1, 12)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (3, 11)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (3, 8)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (3, 7)
INSERT [dbo].[SERIES_LIBRARY] ([SERIES_ID], [USER_ID]) VALUES (2, 9)
SET IDENTITY_INSERT [dbo].[SERVICES] ON 

INSERT [dbo].[SERVICES] ([ID], [SERVICE_NAME], [SERVICE_PRICE]) VALUES (1, N'Базов пакет', 15.99)
INSERT [dbo].[SERVICES] ([ID], [SERVICE_NAME], [SERVICE_PRICE]) VALUES (2, N'Стандартен пакет', 45.99)
INSERT [dbo].[SERVICES] ([ID], [SERVICE_NAME], [SERVICE_PRICE]) VALUES (3, N'VIP пакет', 99.99)
INSERT [dbo].[SERVICES] ([ID], [SERVICE_NAME], [SERVICE_PRICE]) VALUES (4, N'Обикновен', 29.989999771118164)
INSERT [dbo].[SERVICES] ([ID], [SERVICE_NAME], [SERVICE_PRICE]) VALUES (5, N'da', 12)
SET IDENTITY_INSERT [dbo].[SERVICES] OFF
INSERT [dbo].[STORAGE] ([FILM_ID], [FILM_PRICE], [STORAGE_QUANTITUY], [TYPE_ID]) VALUES (1, 15.99, 15, 2)
SET IDENTITY_INSERT [dbo].[SUBSCRIPTIONS] ON 

INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (1, 8, 1, CAST(N'2020-05-06' AS Date), CAST(N'2020-06-06' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (2, 9, 1, CAST(N'2020-05-07' AS Date), CAST(N'2020-06-07' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (3, 10, 3, CAST(N'2020-05-07' AS Date), CAST(N'2020-06-07' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (4, 11, 2, CAST(N'2020-05-08' AS Date), CAST(N'2020-06-08' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (5, 12, 2, CAST(N'2020-05-08' AS Date), CAST(N'2020-06-08' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (6, 13, 3, CAST(N'2020-05-17' AS Date), CAST(N'2020-06-17' AS Date))
INSERT [dbo].[SUBSCRIPTIONS] ([SUBS_ID], [SUBS_USER_ID], [SERVICES_ID], [SUBS_START_DATE], [SUBS_END_DATE]) VALUES (1006, 7, 3, CAST(N'2020-08-29' AS Date), CAST(N'2020-09-29' AS Date))
SET IDENTITY_INSERT [dbo].[SUBSCRIPTIONS] OFF
SET IDENTITY_INSERT [dbo].[TYPES] ON 

INSERT [dbo].[TYPES] ([ID], [TYPE_NAME]) VALUES (1, N'VHS')
INSERT [dbo].[TYPES] ([ID], [TYPE_NAME]) VALUES (2, N'DVD')
INSERT [dbo].[TYPES] ([ID], [TYPE_NAME]) VALUES (3, N'Blu')
INSERT [dbo].[TYPES] ([ID], [TYPE_NAME]) VALUES (4, N'Ray')
SET IDENTITY_INSERT [dbo].[TYPES] OFF
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (1, N'admin                                                                                                                                                                                                                                                           ', N'admin                                                                                                                                                                                                                                                           ', N'yes@gmail.com                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (7, N'cd0b9452fc376fc4c35a60087b366f70d883fc901524daf1f122fbd319384f6a                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'ivan@9abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (8, N'6e885b857804f868c79c20c78f03696636427565a4fbac95d7352d8530bfadf1                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'ivan98@abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (9, N'4c8a68b350c395863ebf2a2f3f6c5202ec51abbe0a4ba7ec251f09ba43305ae7                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'kiro@abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (10, N'8c7d0a50340739cdd57c471cdb0b8412d2061ce9df821302161fe7afad21f961                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'stf@abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (11, N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'123@abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (12, N'86e50149658661312a9e0b35558d84f6c6d3da797f552a9657fe0558ca40cdef                                                                                                                                                                                                ', N'86e50149658661312a9e0b35558d84f6c6d3da797f552a9657fe0558ca40cdef                                                                                                                                                                                                ', N'34@abv.bg                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', 1)
INSERT [dbo].[USERS] ([USER_ID], [USER_USERNAME], [USER_PASSWORD], [USER_EMAIL], [COUNTRY_ID]) VALUES (13, N'4f0b42d144097212a8564d53cae25ca90f411562a7b6cfe4b484036c2e910aff                                                                                                                                                                                                ', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3                                                                                                                                                                                                ', N'goshko@emailbf                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [FK_EMP_CITY_ID] FOREIGN KEY([CITY_ID])
REFERENCES [dbo].[CITIES] ([CITY_ID])
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [FK_EMP_CITY_ID]
GO
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [FK_EMP_POS_ID] FOREIGN KEY([POSITION_ID])
REFERENCES [dbo].[POSITIONS] ([POS_ID])
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [FK_EMP_POS_ID]
GO
ALTER TABLE [dbo].[FILM_LIBRARY]  WITH CHECK ADD  CONSTRAINT [FK_LIBRARY_FILM_ID] FOREIGN KEY([FILM_ID])
REFERENCES [dbo].[FILMS] ([ID])
GO
ALTER TABLE [dbo].[FILM_LIBRARY] CHECK CONSTRAINT [FK_LIBRARY_FILM_ID]
GO
ALTER TABLE [dbo].[FILM_LIBRARY]  WITH CHECK ADD  CONSTRAINT [FK_LIBRARY_USERS_ID] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[FILM_LIBRARY] CHECK CONSTRAINT [FK_LIBRARY_USERS_ID]
GO
ALTER TABLE [dbo].[FILMS]  WITH CHECK ADD  CONSTRAINT [FK_FILMS_GENRE_ID] FOREIGN KEY([GENRE_ID])
REFERENCES [dbo].[GENRES] ([ID])
GO
ALTER TABLE [dbo].[FILMS] CHECK CONSTRAINT [FK_FILMS_GENRE_ID]
GO
ALTER TABLE [dbo].[RENT]  WITH CHECK ADD  CONSTRAINT [FK_RENT_USER_ID] FOREIGN KEY([RENTED_USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[RENT] CHECK CONSTRAINT [FK_RENT_USER_ID]
GO
ALTER TABLE [dbo].[RENT]  WITH CHECK ADD  CONSTRAINT [FK_RENTED_FILM_ID] FOREIGN KEY([FILM_ID])
REFERENCES [dbo].[FILMS] ([ID])
GO
ALTER TABLE [dbo].[RENT] CHECK CONSTRAINT [FK_RENTED_FILM_ID]
GO
ALTER TABLE [dbo].[RENTED_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_FILMS_ID] FOREIGN KEY([FILMS_ID])
REFERENCES [dbo].[FILMS] ([ID])
GO
ALTER TABLE [dbo].[RENTED_STOCKS] CHECK CONSTRAINT [FK_FILMS_ID]
GO
ALTER TABLE [dbo].[RENTED_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_RENTED_ID] FOREIGN KEY([RENTED_FILMS_ID])
REFERENCES [dbo].[RENT] ([RENT_ID])
GO
ALTER TABLE [dbo].[RENTED_STOCKS] CHECK CONSTRAINT [FK_RENTED_ID]
GO
ALTER TABLE [dbo].[SALE]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_ID] FOREIGN KEY([EMPLOYEE_ID])
REFERENCES [dbo].[EMPLOYEES] ([EMP_ID])
GO
ALTER TABLE [dbo].[SALE] CHECK CONSTRAINT [FK_EMPLOYEE_ID]
GO
ALTER TABLE [dbo].[SALE]  WITH CHECK ADD  CONSTRAINT [FK_SALE_USER_ID] FOREIGN KEY([SALE_USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[SALE] CHECK CONSTRAINT [FK_SALE_USER_ID]
GO
ALTER TABLE [dbo].[SERIES]  WITH CHECK ADD  CONSTRAINT [FK_SERIES_GENRE_ID] FOREIGN KEY([GENRE_ID])
REFERENCES [dbo].[GENRES] ([ID])
GO
ALTER TABLE [dbo].[SERIES] CHECK CONSTRAINT [FK_SERIES_GENRE_ID]
GO
ALTER TABLE [dbo].[SERIES_LIBRARY]  WITH CHECK ADD  CONSTRAINT [FK_LIBRARY_SERIES_ID] FOREIGN KEY([SERIES_ID])
REFERENCES [dbo].[SERIES] ([ID])
GO
ALTER TABLE [dbo].[SERIES_LIBRARY] CHECK CONSTRAINT [FK_LIBRARY_SERIES_ID]
GO
ALTER TABLE [dbo].[SERIES_LIBRARY]  WITH CHECK ADD  CONSTRAINT [FK_LIBRARY_USER_ID] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[SERIES_LIBRARY] CHECK CONSTRAINT [FK_LIBRARY_USER_ID]
GO
ALTER TABLE [dbo].[SOLD_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_SALE_ID] FOREIGN KEY([SOLD_SALE_ID])
REFERENCES [dbo].[SALE] ([SALE_ID])
GO
ALTER TABLE [dbo].[SOLD_STOCKS] CHECK CONSTRAINT [FK_SALE_ID]
GO
ALTER TABLE [dbo].[SOLD_STOCKS]  WITH CHECK ADD  CONSTRAINT [FK_STORAGE_INFO] FOREIGN KEY([STORAGE_FILM_ID], [STORAGE_PRICE])
REFERENCES [dbo].[STORAGE] ([FILM_ID], [FILM_PRICE])
GO
ALTER TABLE [dbo].[SOLD_STOCKS] CHECK CONSTRAINT [FK_STORAGE_INFO]
GO
ALTER TABLE [dbo].[STORAGE]  WITH CHECK ADD  CONSTRAINT [FK_STORAGE_FILM_ID] FOREIGN KEY([FILM_ID])
REFERENCES [dbo].[FILMS] ([ID])
GO
ALTER TABLE [dbo].[STORAGE] CHECK CONSTRAINT [FK_STORAGE_FILM_ID]
GO
ALTER TABLE [dbo].[STORAGE]  WITH CHECK ADD  CONSTRAINT [FK_STORAGE_TYPES_ID] FOREIGN KEY([TYPE_ID])
REFERENCES [dbo].[TYPES] ([ID])
GO
ALTER TABLE [dbo].[STORAGE] CHECK CONSTRAINT [FK_STORAGE_TYPES_ID]
GO
ALTER TABLE [dbo].[SUBSCRIPTIONS]  WITH CHECK ADD  CONSTRAINT [FK_SUBSCRIPTIONS_SERVICES_ID] FOREIGN KEY([SERVICES_ID])
REFERENCES [dbo].[SERVICES] ([ID])
GO
ALTER TABLE [dbo].[SUBSCRIPTIONS] CHECK CONSTRAINT [FK_SUBSCRIPTIONS_SERVICES_ID]
GO
ALTER TABLE [dbo].[SUBSCRIPTIONS]  WITH CHECK ADD  CONSTRAINT [FK_SUBSCRIPTIONS_USER_ID] FOREIGN KEY([SUBS_USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[SUBSCRIPTIONS] CHECK CONSTRAINT [FK_SUBSCRIPTIONS_USER_ID]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_COUNTRY_ID] FOREIGN KEY([COUNTRY_ID])
REFERENCES [dbo].[COUNTRIES] ([COUNTRY_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK_USERS_COUNTRY_ID]
GO
/****** Object:  StoredProcedure [dbo].[CITIES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CITIES_INS] @name nvarchar(128)
AS
	INSERT INTO CITIES(CITY_NAME)
		VALUES(@name)
GO
/****** Object:  StoredProcedure [dbo].[CITIES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CITIES_UPD] @id int, @name nvarchar(128)
AS
	UPDATE CITIES
	SET CITY_NAME = @name
	WHERE CITY_ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[COUNTRIES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[COUNTRIES_INS] @country_name char(256)
AS
	INSERT INTO [COUNTRIES](COUNTRY_NAME)
		VALUES(@country_name)
GO
/****** Object:  StoredProcedure [dbo].[COUNTRIES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[COUNTRIES_UPD] @id int, @name nvarchar(256)
AS
	UPDATE COUNTRIES
	SET COUNTRY_NAME = @name
	WHERE COUNTRY_ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[EMP_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EMP_INS] @fname nvarchar (128), @lname nvarchar(128), @salary int, @phone nvarchar(16), @positionID int, @cityID int
AS
	INSERT INTO EMPLOYEES(EMP_FNAME, EMP_LNAME, EMP_SALARY, EMP_PH_N, POSITION_ID, CITY_ID)
		VALUES(@fname, @lname, @salary, @phone, @positionID, @cityID)
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EMPLOYEES_UPD] @id int, @fName nvarchar(128), @lName nvarchar(128), @salary int, @ph nvarchar(16), @posId int, @cityID int
AS
	UPDATE EMPLOYEES
	SET EMP_FNAME = @fName, EMP_LNAME = @lName, EMP_SALARY = @salary, EMP_PH_N = @ph, POSITION_ID = @posId, CITY_ID = @cityID
	WHERE EMP_ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[FILM_LIBRARY_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FILM_LIBRARY_INS] @FILMID INT, @USERID INT
AS	
	INSERT INTO FILM_LIBRARY(FILM_ID, [USER_ID])
		VALUES(@FILMID, @USERID)
GO
/****** Object:  StoredProcedure [dbo].[FILMS_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FILMS_INS] @producer nvarchar(256), @leading nvarchar(256), @film_name nvarchar(128), @genreID int, @filmYear char(16)
AS
	INSERT INTO FILMS(FILM_PRODUCER, FILM_LEADING, FILM_NAME, GENRE_ID, FILM_YEAR)
		VALUES(@producer, @leading, @film_name, @genreID, @filmYear)
GO
/****** Object:  StoredProcedure [dbo].[FILMS_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FILMS_UPD] @id int, @prod nvarchar(256), @lead nvarchar(256), @name nvarchar(128), @genre int, @year char(16)
AS
	UPDATE FILMS
	SET FILM_PRODUCER = @prod, FILM_LEADING = @lead, FILM_NAME = @name, GENRE_ID = @genre, FILM_YEAR = @year
	WHERE ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[GENRES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GENRES_INS] @name nvarchar(128)
AS
	INSERT INTO GENRES(GENRE_NAME)
		VALUES(@name)
GO
/****** Object:  StoredProcedure [dbo].[GENRES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GENRES_UPD] @id int, @name nvarchar(128)
AS
	UPDATE GENRES
	SET GENRE_NAME = @name
	WHERE ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[POSITIONS_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[POSITIONS_INS] @desc nvarchar(128)
AS 
	INSERT INTO POSITIONS (POSITION_DESC)
		VALUES (@desc)
GO
/****** Object:  StoredProcedure [dbo].[POSITIONS_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[POSITIONS_UPD] @id int, @desc nvarchar(128)
AS
	UPDATE POSITIONS
	SET POSITION_DESC = @desc
	WHERE POS_ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[RENT_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RENT_INS] @rentedUserID int, @filmID int, @dateFrom date, @dateTo date
AS 
	INSERT INTO RENT(RENTED_USER_ID, FILM_ID, RENTED_FROM_DATE, RENTED_RETURN_DATE)
		VALUES(@rentedUserID, @filmID, @dateFrom, @dateTo)
GO
/****** Object:  StoredProcedure [dbo].[SALE_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SALE_INS] @sale_date date, @employeeID int, @userID int
AS 
	INSERT INTO SALE(SALE_DATE, EMPLOYEE_ID, SALE_USER_ID)
		VALUES(@sale_date, @employeeID, @userID)
GO
/****** Object:  StoredProcedure [dbo].[SERIES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SERIES_INS] @producer nvarchar(256), @leading nvarchar(256), @series_name nvarchar(256), @season int, @genreID int, @seriesYear char(16)
AS 
	INSERT INTO SERIES(SERIES_PRODUCER, SERIES_LEADING, SERIES_NAME, SERIES_SEASON, GENRE_ID, SERIES_YEAR)
		VALUES(@producer, @leading,@series_name, @season, @genreID, @seriesYear)
GO
/****** Object:  StoredProcedure [dbo].[SERIES_LIBRARY_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SERIES_LIBRARY_INS] @SERIESID INT, @USERID INT
AS 
	INSERT INTO SERIES_LIBRARY(SERIES_ID, [USER_ID])
		VALUES (@SERIESID, @USERID)
GO
/****** Object:  StoredProcedure [dbo].[SERIES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SERIES_UPD] @id int, @prod nvarchar(256), @lead nvarchar(256), @name nvarchar(128), @season int, @genre int, @year char(16)
AS
	UPDATE SERIES	
	SET SERIES_PRODUCER = @prod, SERIES_LEADING = @lead, SERIES_NAME = @name, SERIES_SEASON = @season, GENRE_ID = @genre, SERIES_YEAR = @year
	WHERE ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[SERVICES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SERVICES_INS] @name nvarchar(128), @price float
AS 
	INSERT INTO [SERVICES]([SERVICE_NAME], [SERVICE_PRICE])
		VALUES (@name, @price)
GO
/****** Object:  StoredProcedure [dbo].[SERVICES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SERVICES_UPD] @id int, @serviceName nvarchar(128), @servicePrice float
AS
	UPDATE [SERVICES]
	SET [SERVICE_NAME] = @serviceName, [SERVICE_PRICE] = @servicePrice
	WHERE ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[SOLD_STOCKS_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SOLD_STOCKS_INS] @storageFilmID int, @storagePrice float, @quantitySold int, @saleID int
AS
	INSERT INTO SOLD_STOCKS(STORAGE_FILM_ID, STORAGE_PRICE, QUANTITY_SOLD, SOLD_SALE_ID)
		VALUES (@storageFilmID, @storagePrice, @quantitySold, @saleID)
GO
/****** Object:  StoredProcedure [dbo].[STORAGE_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STORAGE_INS] @filmID int, @filmPrice float, @quantity int, @typeID int
AS
	INSERT INTO STORAGE(FILM_ID, FILM_PRICE, STORAGE_QUANTITUY, [TYPE_ID])
		VALUES(@filmID, @filmPrice, @quantity, @typeID)
GO
/****** Object:  StoredProcedure [dbo].[STORAGE_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[STORAGE_UPD] @filmID int, @priceOld float, @priceNew float, @quantity int, @type int
AS
	UPDATE STORAGE	
	SET FILM_PRICE = @priceNew, STORAGE_QUANTITUY = @quantity, [TYPE_ID] = @type
	WHERE FILM_ID = @filmID AND FILM_PRICE = @priceOld;
GO
/****** Object:  StoredProcedure [dbo].[SUBSCRIPTION_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SUBSCRIPTION_INS] @userID int, @servicesID int, @startDate date, @endDate date
AS
	INSERT INTO SUBSCRIPTIONS(SUBS_USER_ID, SERVICES_ID, SUBS_START_DATE, SUBS_END_DATE)
		VALUES(@userID, @servicesID, @startDate, @endDate)
GO
/****** Object:  StoredProcedure [dbo].[SUBSCRIPTION_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SUBSCRIPTION_UPD] @subsID int, @userID int, @servicesID int, @startDate date, @endDate date
AS
	UPDATE SUBSCRIPTIONS
	SET SUBS_USER_ID = @userID, SERVICES_ID = @servicesID, SUBS_START_DATE = @startDate, SUBS_END_DATE = @endDate
	WHERE SUBS_ID = @subsID;
GO
/****** Object:  StoredProcedure [dbo].[TYPES_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TYPES_INS] @name nvarchar(128)
AS
	INSERT INTO [TYPES]([TYPE_NAME])
		VALUES(@name)
GO
/****** Object:  StoredProcedure [dbo].[TYPES_UPD]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TYPES_UPD] @id int, @name nvarchar(128)
AS 
	UPDATE [TYPES]
	SET [TYPE_NAME] = @name
	WHERE [ID] = @id;
GO
/****** Object:  StoredProcedure [dbo].[USERS_INS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERS_INS] @userName char(512), @password char(512), @email char(512), @countryID int
AS
	INSERT INTO USERS(USER_USERNAME, USER_PASSWORD, USER_EMAIL, COUNTRY_ID)
		VALUES (@userName, @password, @email, @countryID)
GO
/****** Object:  StoredProcedure [dbo].[USERS_UPD_EMAIL]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERS_UPD_EMAIL] @id int, @email char(512)
AS
	UPDATE USERS	
	SET USER_EMAIL = @email
	WHERE [USER_ID] = @id;
GO
/****** Object:  StoredProcedure [dbo].[USERS_UPD_NAME]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERS_UPD_NAME] @id int, @userName nvarchar(512)
AS
	UPDATE USERS
	SET USER_USERNAME = @userName
	WHERE [USER_ID] = @id;
GO
/****** Object:  StoredProcedure [dbo].[USERS_UPD_PASS]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERS_UPD_PASS] @id int, @pass nvarchar(512)
 AS
	UPDATE USERS	
	SET USER_PASSWORD = @pass
	WHERE [USER_ID] = @id;
GO
/****** Object:  StoredProcedure [dbo].[USERS_UPR_COUNTRY]    Script Date: 8/29/2020 6:39:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USERS_UPR_COUNTRY] @id int, @countryID int
AS 
	UPDATE USERS	
	SET COUNTRY_ID = @countryID
	WHERE [USER_ID] = @id;
GO
USE [master]
GO
ALTER DATABASE [VideoShop] SET  READ_WRITE 
GO
