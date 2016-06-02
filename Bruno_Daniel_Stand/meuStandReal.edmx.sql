
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2016 12:15:10
-- Generated from EDMX file: C:\Users\Bruno\Desktop\Bruno_Daniel_Stand\Bruno_Daniel_Stand\meuStandReal.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [myStandReal];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_ClienteCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_ParcelaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcelas] DROP CONSTRAINT [FK_ParcelaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servicos] DROP CONSTRAINT [FK_ServicoCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alugueres] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_AluguerCarroAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alugueres] DROP CONSTRAINT [FK_AluguerCarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Parcelas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcelas];
GO
IF OBJECT_ID(N'[dbo].[Servicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servicos];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Carros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros];
GO
IF OBJECT_ID(N'[dbo].[Alugueres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alugueres];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroVenda];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroAluguer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Parcelas'
CREATE TABLE [dbo].[Parcelas] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Servico_IdServico] int  NOT NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] nvarchar(max)  NOT NULL,
    [DataSaida] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [CarroOficina_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Alugueres'
CREATE TABLE [dbo].[Alugueres] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] nvarchar(max)  NOT NULL,
    [DataFim] nvarchar(max)  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroOficina'
CREATE TABLE [dbo].[Carros_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroAluguer'
CREATE TABLE [dbo].[Carros_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroVenda'
CREATE TABLE [dbo].[Carros_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [VendaIdVenda] int  NULL,
    [IdCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdParcela] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [PK_Parcelas]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'Alugueres'
ALTER TABLE [dbo].[Alugueres]
ADD CONSTRAINT [PK_Alugueres]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [PK_Carros_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [PK_Carros_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [PK_Carros_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[Carros_CarroOficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [Servico_IdServico] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [FK_ParcelaServico]
    FOREIGN KEY ([Servico_IdServico])
    REFERENCES [dbo].[Servicos]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParcelaServico'
CREATE INDEX [IX_FK_ParcelaServico]
ON [dbo].[Parcelas]
    ([Servico_IdServico]);
GO

-- Creating foreign key on [CarroOficina_IdCarro] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_ServicoCarroOficina]
    FOREIGN KEY ([CarroOficina_IdCarro])
    REFERENCES [dbo].[Carros_CarroOficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoCarroOficina'
CREATE INDEX [IX_FK_ServicoCarroOficina]
ON [dbo].[Servicos]
    ([CarroOficina_IdCarro]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Alugueres'
ALTER TABLE [dbo].[Alugueres]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[Alugueres]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'Alugueres'
ALTER TABLE [dbo].[Alugueres]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[Carros_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[Alugueres]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [VendaIdVenda] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([VendaIdVenda])
    REFERENCES [dbo].[Vendas]
        ([IdVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[Carros_CarroVenda]
    ([VendaIdVenda]);
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------