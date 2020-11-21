--
-- Table structure for table `Contato`
--
create table if not exists Contato(
idContato int not null auto_increment,
Email varchar(100),
constraint PK_Contato primary key(idContato)
)ENGINE=InnoDB;

--
-- Table structure for table `Cliente`
--
create table if not exists Cliente(
idCliente int not null auto_increment,
Nome varchar(150), 
Cpf varchar(20), 
Idade int,
constraint PK_Cliente primary key(idCliente)
)ENGINE=InnoDB;

--
-- Table structure for table `Funcionario`
--
create table if not exists Funcionario(
idFuncionario int not null auto_increment,
Nome varchar(150), 
Cargo varchar(60), 
Salario float,
constraint PK_Funcionario primary key(idFuncionario)
)ENGINE=InnoDB;

--
-- Table structure for table `Produto`
--
create table if not exists Produto(
idProduto int not null auto_increment,
Nome varchar(150),
Preco float, 
QtdEstoque int,
constraint PK_Produto primary key(idProduto)
)ENGINE=InnoDB;
