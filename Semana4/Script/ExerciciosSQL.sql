INSERT INTO Funcionario (Nome) values ('Felipe')
INSERT INTO Funcionario (Nome) values ('Giomar')

INSERT INTO Produtos (Nome,Valor) values ('Skol beats',5.49)
INSERT INTO Produtos (Nome,Valor) values ('Budweiser',4.94)
INSERT INTO Produtos (Nome,Valor) values ('Patagonia',7.69)
INSERT INTO Produtos (Nome,Valor) values ('Stella Arotois',8.49)
INSERT INTO Produtos (Nome,Valor) values ('Corona Extra',8.20)

SELECT * FROM Funcionario;
SELECT * FROM Produtos

INSERT INTO Pedidos (FuncionarioId,ProdutoId,Quantidade) values (1,3, 2)
INSERT INTO Pedidos (FuncionarioId,ProdutoId,Quantidade) values (1,1, 5)

INSERT INTO Pedidos (FuncionarioId,ProdutoId,Quantidade) values (2,2, 3)
INSERT INTO Pedidos (FuncionarioId,ProdutoId,Quantidade) values (2,4, 6)

SELECT * FROM Funcionario ORDER BY Nome 
SELECT * FROM Produtos ORDER BY Valor DESC

SELECT ped.Id, fun.Nome, ped.ProdutoId, ped.Quantidade FROM Pedidos ped inner join Funcionario fun on ped.FuncionarioId = fun.Id

SELECT fun.Nome, SUM(ped.Quantidade) as 'Quantidade' FROM Pedidos ped inner join Funcionario fun on ped.FuncionarioId = fun.Id
GROUP BY fun.Nome

SELECT fun.Nome, SUM(ped.Quantidade * pro.Valor) as 'Valor Total' FROM Pedidos ped inner join Funcionario fun on ped.FuncionarioId = fun.Id
                                                                  inner join Produtos pro on ped.ProdutoId = pro.Id
GROUP BY fun.Nome

select * from Produtos;
select * from Pedidos

SELECT  pro.*, ped.Quantidade from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
ORDER BY ped.Quantidade

SELECT TOP 1 pro.Nome, SUM(ped.Quantidade) as 'Quantidade' FROM Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
GROUP BY pro.Nome
ORDER BY SUM(ped.Quantidade) DESC

SELECT TOP 1 pro.Nome, SUM(ped.Quantidade * pro.Valor) as 'Receita Total' FROM Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
GROUP BY pro.Nome
ORDER BY SUM(ped.Quantidade * pro.Valor) DESC



SELECT * FROM Funcionario fun inner join Pedidos ped on fun.Id = ped.FuncionarioId
                              inner join Produtos pro on ped.ProdutoId = pro.Id
							  WHERE fun.Nome like 'Giomar%'

SELECT * FROM Produtos pro left join Pedidos ped on pro.Id = ped.ProdutoId
WHERE ped.ProdutoId is null

SELECT pro.Nome, COUNT(ped.ProdutoId) as 'Quantidade' FROM Produtos pro left join Pedidos ped on pro.Id = ped.ProdutoId
GROUP BY pro.Nome
ORDER BY 'Quantidade' DESC
 
