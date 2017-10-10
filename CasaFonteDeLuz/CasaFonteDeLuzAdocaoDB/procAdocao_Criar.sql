CREATE PROCEDURE [dbo].[procAdocao_Criar]
	@IdAfilhado			char(10)
,	@emailPadrinho		varchar(150)
,	@nomePadrinho		varchar(150)
,	@comentarioPadrinho	varchar(150)
,	@telefonePadrinho	varchar(20)

AS
	INSERT INTO
		dbo.Adocao
	(	
		IdAfilhado
	,	emailPadrinho		
	,	nomePadrinho		
	,	comentarioPadrinho	
	,	telefonePadrinho
	)
	VALUES
	(
		@IdAfilhado
	,	@emailPadrinho		
	,	@nomePadrinho		
	,	@comentarioPadrinho	
	,	@telefonePadrinho
	)