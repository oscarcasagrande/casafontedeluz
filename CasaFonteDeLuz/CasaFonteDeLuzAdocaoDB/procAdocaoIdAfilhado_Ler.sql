CREATE PROCEDURE [dbo].[procAdocaoIdAfilhado_Ler]
	@IdAfilhado	int
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
