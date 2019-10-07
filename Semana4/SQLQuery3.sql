select *from Usuarios
GO
select * from Marcas
GO

update Marcas set UsuInc = 1
where UsuInc = 0
GO


Select mar.Nome
from Marcas mar inner join Usuarios usu on mar.Usuinc = usu.Id
where usu.Usuario like 'Felipe%' 

select Nome from Marcas
where UsuInc = 1
GO

select Nome from Marcas 
where UsuInc = 2
GO

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Id = 1 
Order by COUNT (Usu.Usuinc) desc
GO

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Id = 2 
Order by COUNT(mar.UsuInc) desc
GO

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%'
GO

select car.Modelo from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
GO

select car.Modelo from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
GO

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by Count(car.UsuInc) desc
GO

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by Count(car.UsuInc) asc
GO

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%'
GO



