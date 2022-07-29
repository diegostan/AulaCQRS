USE [master]
GO

CREATE DATABASE [BANCO_FROTA]
GO

USE [BANCO_FROTA]
GO

CREATE TABLE [TB_VEHICLE]
(
    [ID] INT PRIMARY KEY IDENTITY(1,1),
    [CL_NAME] NVARCHAR(12),
    [CL_COLOR] NVARCHAR(12),
    [CL_MODEL_YEAR] INT NOT NULL,
    [CL_CATEGORY_ID] INT NOT NULL,
    [CL_PRICE] FLOAT NOT NULL,
    [CL_TYPE] INT NOT NULL,
    [CL_CREATED_ON] DATETIME 
    CONSTRAINT FK_CATEGORY_ID FOREIGN KEY (CL_CATEGORY_ID) REFERENCES [TB_VEHICLE_CATEGORY]([ID])
)
GO

CREATE TABLE [TB_VEHICLE_CATEGORY]
(
    [ID] INT PRIMARY KEY IDENTITY(1,1),
    [CL_NAME] NVARCHAR(32),
    [CL_CREATED_ON] DATETIME
)
GO