CREATE PROCEDURE [dbo].[procAdocaoIdAfilhado_Ler]
	@IdAfilhado	char(10)
AS
	SELECT
		IdAfilhado
	,	emailPadrinho
	,	nomePadrinho
	,	comentarioPadrinho
	,	telefonePadrinho
	,	dataCriacao
	FROM
		dbo.Adocao
	where
		IdAfilhado	=	@IdAfilhado
