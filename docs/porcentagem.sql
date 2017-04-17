select * from alunos

create table Tporcentagem (
  id_pergunta int identity not null,
  num_questao varchar(2),
  respAluno varchar(40) not null,
  gabarito varchar(40),
  pontuacao int,
  ra_jogador int,
  duracao varchar(10),
  data datetime default getdate()
)

insert into Tporcentagem (num_questao, respAluno, gabarito, pontuacao, ra_jogador, duracao) values ('1', '2000 litros', '2400 litros', 2, 101010,'1min20s');

select * from Tporcentagem

select nome from alunos where ra = 170000750

drop table Tporcentagem
truncate table Tporcentagem

select num_questao, nome, respAluno, pontuacao from Tporcentagem, alunos
where alunos.ra = Tporcentagem.ra_jogador and alunos.ra = 170000750