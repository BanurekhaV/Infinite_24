
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2024 15:21:20
-- Generated from EDMX file: C:\Banu\Infinite\B3\EF\ModelFirst\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [4WheelersDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [CarID] int IDENTITY(1,1) NOT NULL,
    [CarName] nvarchar(max)  NOT NULL,
    [CarCost] float  NOT NULL,
    [ManufacturerId] int  NOT NULL
);
GO

-- Creating table 'Manufacturers'
CREATE TABLE [dbo].[Manufacturers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MName] nvarchar(max)  NOT NULL,
    [CarID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarID] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([CarID] ASC);
GO

-- Creating primary key on [Id] in table 'Manufacturers'
ALTER TABLE [dbo].[Manufacturers]
ADD CONSTRAINT [PK_Manufacturers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManufacturerId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_ManufacturerCar]
    FOREIGN KEY ([ManufacturerId])
    REFERENCES [dbo].[Manufacturers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerCar'
CREATE INDEX [IX_FK_ManufacturerCar]
ON [dbo].[Cars]
    ([ManufacturerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------