USE [master]
GO

/****** Object:  Database [Streaming]    Script Date: 17/05/2023 09:37:57 ******/
CREATE DATABASE [Streaming]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Streaming', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Streaming.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Streaming_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Streaming_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Streaming].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Streaming] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Streaming] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Streaming] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Streaming] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Streaming] SET ARITHABORT OFF 
GO

ALTER DATABASE [Streaming] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Streaming] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Streaming] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Streaming] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Streaming] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Streaming] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Streaming] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Streaming] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Streaming] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Streaming] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Streaming] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Streaming] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Streaming] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Streaming] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Streaming] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Streaming] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Streaming] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Streaming] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Streaming] SET  MULTI_USER 
GO

ALTER DATABASE [Streaming] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Streaming] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Streaming] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Streaming] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Streaming] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Streaming] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Streaming] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Streaming] SET  READ_WRITE 
GO

/****** tabela tblClassificação ******/

USE [Streaming]
GO

/****** Object:  Table [dbo].[tblClassificacao]    Script Date: 17/05/2023 09:41:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblClassificacao](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[IdadeMaxima] [varchar](20) NULL,
	[Descricao] [varchar](max) NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblClassificacao] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblClassificacao] ADD  CONSTRAINT [DF_tblClassificacao_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO


/****** tabela Genero ******/

USE [Streaming]
GO

/****** Object:  Table [dbo].[tblGenero]    Script Date: 17/05/2023 09:42:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblGenero](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblGenero] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblGenero] ADD  CONSTRAINT [DF_tblGenero_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO

/****** tabela Sexo ******/

USE [Streaming]
GO

/****** Object:  Table [dbo].[tblSexo]    Script Date: 17/05/2023 09:43:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSexo](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblSexo] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblSexo] ADD  CONSTRAINT [DF_tblSexo_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO


/****** tabela Tipo Streaming ******/

USE [Streaming]
GO

/****** Object:  Table [dbo].[tblTipoStreaming]    Script Date: 17/05/2023 09:44:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTipoStreaming](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblTipoStreaming] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblTipoStreaming] ADD  CONSTRAINT [DF_tblTipoStreaming_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO

/****** tabela Usuario ******/


USE [Streaming]
GO

/****** Object:  Table [dbo].[tblUsuario]    Script Date: 17/05/2023 09:45:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblUsuario](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Idade] [int] NULL,
	[Email] [varchar](100) NULL,
	[CodigoSexo] [int] NULL,
	[CodigoGenero] [int] NULL,
	[Senha] [varchar](30) NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblUsuario] ADD  CONSTRAINT [DF_tblUsuario_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO

ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblGenero] FOREIGN KEY([CodigoGenero])
REFERENCES [dbo].[tblGenero] ([Codigo])
GO

ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblGenero]
GO

ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblSexo] FOREIGN KEY([CodigoSexo])
REFERENCES [dbo].[tblSexo] ([Codigo])
GO

ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblSexo]
GO

/****** tabela Streaming ******/

USE [Streaming]
GO

/****** Object:  Table [dbo].[tblStreaming]    Script Date: 17/05/2023 09:45:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblStreaming](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Lancamento] [datetime] NULL,
	[Nota] [int] NULL,
	[Descricao] [varchar](max) NULL,
	[CodigoClassificacao] [int] NULL,
	[CodigoGenero] [int] NULL,
	[CodigoTipoStreaming] [int] NULL,
	[Imagem] [varbinary](max) NULL,
	[Criacao] [datetime] NULL,
 CONSTRAINT [PK_tblStreaming] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblStreaming] ADD  CONSTRAINT [DF_tblStreaming_Criacao]  DEFAULT (getdate()) FOR [Criacao]
GO

ALTER TABLE [dbo].[tblStreaming]  WITH CHECK ADD  CONSTRAINT [FK_tblStreaming_tblClassificacao] FOREIGN KEY([CodigoClassificacao])
REFERENCES [dbo].[tblClassificacao] ([Codigo])
GO

ALTER TABLE [dbo].[tblStreaming] CHECK CONSTRAINT [FK_tblStreaming_tblClassificacao]
GO

ALTER TABLE [dbo].[tblStreaming]  WITH CHECK ADD  CONSTRAINT [FK_tblStreaming_tblGenero] FOREIGN KEY([CodigoGenero])
REFERENCES [dbo].[tblGenero] ([Codigo])
GO

ALTER TABLE [dbo].[tblStreaming] CHECK CONSTRAINT [FK_tblStreaming_tblGenero]
GO

ALTER TABLE [dbo].[tblStreaming]  WITH CHECK ADD  CONSTRAINT [FK_tblStreaming_tblTipoStreaming] FOREIGN KEY([CodigoTipoStreaming])
REFERENCES [dbo].[tblTipoStreaming] ([Codigo])
GO

ALTER TABLE [dbo].[tblStreaming] CHECK CONSTRAINT [FK_tblStreaming_tblTipoStreaming]
GO



USE [Streaming]

insert into tblgenero(Descricao) values ('Comedia')
insert into tblgenero(Descricao) values ('Terror')

insert into tblsexo (Descricao) values ('Masculino')
insert into tblsexo (Descricao) values ('Feminino')

insert into tblClassificacao(nome, IdadeMaxima, Descricao) values ('Livre', 'Todas', 'Todas as Idades')
insert into tblClassificacao(nome, IdadeMaxima, Descricao) values ('Infantil', '10', 'Permitido para maiores de 10 anos')

insert into tblTipoStreaming(Descricao) values ('Filmes')
insert into tblTipoStreaming(Descricao) values ('Séries')

insert into tblUsuario(Nome, idade, email, CodigoSexo, CodigoGenero, senha) values ('Administrador',49,'adm@gmail.com',1,1,'1234')

