CREATE PROCEDURE [dbo].[procAdocao_Ler]

AS
	SELECT
		IdCrianca
	,	emailPadrinho
	,	nomePadrinho
	,	comentarioPadrinho
	,	telefonePadrinho
	,	dataCriacao

	FROM
		dbo.Adocao
