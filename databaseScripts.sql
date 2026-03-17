CREATE TABLE [dbo].[Elevi]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] VARCHAR(50) NOT NULL, 
    [Parola] VARCHAR(50) NOT NULL
)
CREATE TABLE [dbo].[Note]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdElevi] INT NOT NULL, 
    [Matematica] INT NULL, 
    [Romana] INT NULL, 
    [Informatica] INT NULL, 
    [Engleza] INT NULL, 
    [Istorie] INT NULL, 
    [Chimie] INT NULL, 
    [Biologie] INT NULL, 
    [Fizica] INT NULL, 
    [Geografie] INT NULL, 
    CONSTRAINT [NoteToElevi] FOREIGN KEY ([IdElevi]) REFERENCES [dbo].[Elevi] ([Id])
)

CREATE TABLE [dbo].[Teze]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdElev] INT NOT NULL, 
    [TezaMatematica] INT NULL, 
    [TezaRomana] INT NULL, 
    [TezaChimie] INT NULL, 
    [TezaFizica] INT NULL, 
    [TezaBiologie] INT NULL, 
    [TezaInformatica] INT NULL,
    CONSTRAINT [EleviToTeza] FOREIGN KEY ([IdElev]) REFERENCES [dbo].[Elevi]([Id])
)


