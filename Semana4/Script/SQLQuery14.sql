select * from Livros
GO
update Livros set Ativo = 0 where Id = (4)
GO
select Id, Nome, DataCriacao from Livros where Ativo = 1