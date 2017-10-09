CREATE TABLE [dbo].[Adocao]
(
	[IdCrianca] INT NOT NULL PRIMARY KEY, 
    [emailPadrinho] VARCHAR(150) NULL, 
    [nomePadrinho] VARCHAR(150) NULL, 
    [comentarioPadrinho] VARCHAR(150) NULL, 
    [telefonePadrinho] VARCHAR(20) NULL, 
    [dataCriacao] DATETIME NOT NULL DEFAULT getdate()
)
