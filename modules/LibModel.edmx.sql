
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/21/2022 22:46:29
-- Generated from EDMX file: C:\Users\majid\source\repos\LibraryManagment\modules\LibModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LibDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RollMember]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Members] DROP CONSTRAINT [FK_RollMember];
GO
IF OBJECT_ID(N'[dbo].[FK_BookLoan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Loans] DROP CONSTRAINT [FK_BookLoan];
GO
IF OBJECT_ID(N'[dbo].[FK_ShelfBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Books] DROP CONSTRAINT [FK_ShelfBook];
GO
IF OBJECT_ID(N'[dbo].[FK_MemberLoan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Members] DROP CONSTRAINT [FK_MemberLoan];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Books]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID(N'[dbo].[Loans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Loans];
GO
IF OBJECT_ID(N'[dbo].[Members]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Members];
GO
IF OBJECT_ID(N'[dbo].[Rolls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rolls];
GO
IF OBJECT_ID(N'[dbo].[Shelves]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shelves];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [id] int IDENTITY(1,1) NOT NULL,
    [BookName] varchar(50)  NOT NULL,
    [Auther] varchar(50)  NOT NULL,
    [Publisher] varchar(50)  NOT NULL,
    [Count] int  NOT NULL,
    [Shabak] int  NOT NULL,
    [ShelfShelfId] int  NOT NULL
);
GO

-- Creating table 'Loans'
CREATE TABLE [dbo].[Loans] (
    [id] int IDENTITY(1,1) NOT NULL,
    [LoanDate] datetime  NOT NULL,
    [ReturnDate] datetime  NULL,
    [Book_id] int  NOT NULL,
    [Member_id] int  NOT NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [Family] varchar(50)  NULL,
    [NC] char(10)  NULL,
    [Email] varchar(50)  NOT NULL,
    [Mobile] nchar(11)  NOT NULL,
    [UserName] varchar(50)  NULL,
    [Password] varchar(50)  NULL,
    [RollRollId] int  NOT NULL
);
GO

-- Creating table 'Rolls'
CREATE TABLE [dbo].[Rolls] (
    [RollId] int IDENTITY(1,1) NOT NULL,
    [RollName] varchar(50)  NULL
);
GO

-- Creating table 'Shelves'
CREATE TABLE [dbo].[Shelves] (
    [ShelfId] int IDENTITY(1,1) NOT NULL,
    [ShelfName] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [PK_Loans]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [RollId] in table 'Rolls'
ALTER TABLE [dbo].[Rolls]
ADD CONSTRAINT [PK_Rolls]
    PRIMARY KEY CLUSTERED ([RollId] ASC);
GO

-- Creating primary key on [ShelfId] in table 'Shelves'
ALTER TABLE [dbo].[Shelves]
ADD CONSTRAINT [PK_Shelves]
    PRIMARY KEY CLUSTERED ([ShelfId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RollRollId] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [FK_RollMember]
    FOREIGN KEY ([RollRollId])
    REFERENCES [dbo].[Rolls]
        ([RollId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RollMember'
CREATE INDEX [IX_FK_RollMember]
ON [dbo].[Members]
    ([RollRollId]);
GO

-- Creating foreign key on [Book_id] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [FK_BookLoan]
    FOREIGN KEY ([Book_id])
    REFERENCES [dbo].[Books]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookLoan'
CREATE INDEX [IX_FK_BookLoan]
ON [dbo].[Loans]
    ([Book_id]);
GO

-- Creating foreign key on [ShelfShelfId] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK_ShelfBook]
    FOREIGN KEY ([ShelfShelfId])
    REFERENCES [dbo].[Shelves]
        ([ShelfId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShelfBook'
CREATE INDEX [IX_FK_ShelfBook]
ON [dbo].[Books]
    ([ShelfShelfId]);
GO

-- Creating foreign key on [Member_id] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [FK_MemberLoan]
    FOREIGN KEY ([Member_id])
    REFERENCES [dbo].[Members]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberLoan'
CREATE INDEX [IX_FK_MemberLoan]
ON [dbo].[Loans]
    ([Member_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------