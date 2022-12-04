CREATE DATABASE [Unitess]
go

use [Unitess]
go

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[JobTitle] [nvarchar](50) NULL
) ON [PRIMARY]

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Kevin Jones','Painter')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Eugene Myers','Paralegal')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Virginia Flores','Recreational Therapist')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Constance Munoz','Clinical Laboratory Technician')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Joshua Martin','Actuary')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('James Vargas','Middle School Teacher')
GO

INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('John Parker','Dentist')
GO


INSERT INTO [dbo].[Contact]
           ([Name]
           ,[JobTitle])
     VALUES
           ('Vernon Jimenez','Statistician')
GO






