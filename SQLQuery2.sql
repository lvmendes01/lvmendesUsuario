drop table __EFMigrationsHistory;
drop table Cardapio;
drop table Cliente;
drop table Idioma;
drop table IdiomaCardapio;
drop table Mesa;
drop table Nacionalidade;
drop table Produto;
drop table ProdutoMesa;
drop table ProdutosCardapio;
drop table Restaurante;
drop table Usuario;

delete from  __EFMigrationsHistory;
delete from Cardapio;
delete from Cliente;
delete from Idioma;
delete from IdiomaCardapio;
delete from Mesa;
delete from Nacionalidade;
delete from Produto;
delete from ProdutoMesa;
delete from ProdutosCardapio;
delete from Restaurante;
delete from Usuario;

select * from Usuario