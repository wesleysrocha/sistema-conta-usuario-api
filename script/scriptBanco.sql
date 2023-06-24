create database sistema_conta_usuario;
use sistema_conta_usuario;
select * from contasusuarios;
insert into contasusuarios (id, titular, email, agencia, numero, tipoConta, saldo) values (null, "Maria Silva", "maria.silva@email.com", "0001", "11111-1", "0 - Conta Corrente", 2),
(null, "Lucas Ferreira", "lucas.ferreira@email.com", "0001", "22222-2", "1 - Conta Poupança", 50),
(null, "Paulo Andrade", "paulo.andrade@email.com", "0002", "22222-2", "2 - Conta Investimentos", 100);