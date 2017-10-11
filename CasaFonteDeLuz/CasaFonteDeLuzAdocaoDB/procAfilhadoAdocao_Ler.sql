CREATE PROCEDURE [dbo].[procAfilhadoAdocao_Ler]
AS
	SELECT
		Afilhado.IdAfilhado
	,	case
			when Adocao.IdAfilhado	is null then 0
			else 1
		end as Apadrinhado
	FROM
		dbo.Afilhado with(nolock)
	left join
		dbo.Adocao with(nolock)
			on	Afilhado.IdAfilhado	=	Adocao.IdAfilhado
	ORDER BY
		2 ASC