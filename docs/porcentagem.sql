select * from alunos

create table Tporcentagem (
  id_pergunta int identity not null,
  respAluno varchar(40) not null,
  gabarito varchar(40),
  pontuacao int,
  ra_jogador int,
  duracao varchar(10),
  data datetime default getdate()
)

insert into Tporcentagem (respAluno, gabarito, pontuacao, ra_jogador, duracao) values ('2000 litros', '2400 litros', 2, 101010,'1min20s');

select * from Tporcentagem

select nome from alunos where ra = 170000750

drop table Tporcentagem
truncate table Tporcentagem