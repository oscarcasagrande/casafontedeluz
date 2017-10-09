CREATE PROCEDURE [dbo].[procAdocao_Criar]
	@IdCrianca			int
,	@emailPadrinho		varchar(150)
,	@nomePadrinho		varchar(150)
,	@comentarioPadrinho	varchar(150)
,	@telefonePadrinho	varchar(20)

AS
	INSERT INTO
		dbo.Adocao
	(	
		IdCrianca
	,	emailPadrinho		
	,	nomePadrinho		
	,	comentarioPadrinho	
	,	telefonePadrinho
	)
	VALUES
	(
		@IdCrianca			
	,	@emailPadrinho		
	,	@nomePadrinho		
	,	@comentarioPadrinho	
	,	@telefonePadrinho
	)