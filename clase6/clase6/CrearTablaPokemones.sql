use POKEDEX_DB
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table [dbo].[POKEMONS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero]  [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](200) NULL,
	[UrlImagen] [varchar](200) NULL,
	[IdTipo]  [int] NULL,
	[IdDebilidad]  [int] NULL,
	[IdEvolucion]  [int] NULL,
	[Activo]  [int] NULL,
	CONSTRAINT [PK_POKEMONS] PRIMARY KEY CLUSTERED
	(
	[Id] ASC
	)
)
GO

use POKEDEX_DB
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table [dbo].[ELEMENTOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	CONSTRAINT [PK_ELEMENTOS] PRIMARY KEY CLUSTERED
	(
	[Id] ASC
	)
)
GO

USE POKEDEX_DB
GO
insert into ELEMENTOS values ('Planta')
insert into ELEMENTOS values ('Fuego')
insert into ELEMENTOS values ('Agua')

insert into POKEMONS values (1, 'Bulbasaur', 'There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/001.png', 1, 2, NULL, 1)
insert into POKEMONS values (4, 'Charmander', 'It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/004.png', 2, 3, NULL, 1)
insert into POKEMONS values (12, 'Butterfree', 'It loves the nectar of flowers and can locate flower patches that have even tiny amounts of pollen.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/012.png', 1, 1, NULL, 1) 
insert into POKEMONS values (16, 'Pidgey', 'Very docile. If attacked, it will often kick up sand to protect itself rather than fight back', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/016.png', 2, 1, NULL, 1)
