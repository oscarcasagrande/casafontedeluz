﻿CREATE PROCEDURE [dbo].[procAdocao_Ler]

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
