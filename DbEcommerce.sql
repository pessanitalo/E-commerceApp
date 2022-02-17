create database ecommerceApp;
use ecommerceApp;

create table Pedidos(
Id int not null primary key identity,
ClienteId int not null,
ItemPedidoID int not null,
Totalpedido decimal not null,
constraint fk_id_pedidos foreign key (Id) references Clientes(id),
constraint fk_id_itempedido foreign key (Id) references ItemsPedidos(Id)
);

create table Clientes(
Id int not null primary key identity,
Nome varchar(30) not null,
Telefone varchar(11) not null,
DataNascimento varchar(8) not null,
Cpf varchar(11) not null,
Email varchar(50) not null,
);


create table ItemsPedidos(
Id int not null primary key identity,
ProdutoId int not null,
Quantidade int not null,
Preco decimal not null,
constraint fk_id_produtos foreign key (Id) references Produtos
);


create table Produtos(
Id int not null primary key identity,
Nome varchar(30) not null,
Preco decimal not null,
TotalEstoque int not null,
Fornecedor varchar(30) not null,
DataCadastro varchar(8) not null,
DataSaida varchar(8),
);
