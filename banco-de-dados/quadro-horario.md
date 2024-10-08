# Grade Horário

## Cadastro de unidade

*Não contemplado nesta fase*

## Cadastro das disciplinas
   
Já contemplado no esquema **pedagógico**
   
## Relação professor e disciplina

Já contemplado no esquema **pedagógico**
   
## Cadastro da grade currícular das turmas

Já contemplado no esquema **pedagógico**

## Horário escolar

*Uma turma tem vários horários*

GRD_Horario
Id  |IdTurma    |Inicio |Fim    |Tipo
0   |0          |07:00  |08:00  |0 (Aula)
1   |0          |08:00  |09:00  |0 (Aula)
2   |0          |09:00  |09:20  |0 (Intervalo)
3   |0          |09:20  |10:20  |0 (Aula)
4   |0          |10:20  |11:20  |0 (Aula)

GRD_HorarioSemana
Id  |IdHorario  |Semana
0   |0          |1 (Segunda)
1   |0          |2 (Terça)
2   |0          |3 (Quarta)
3   |0          |4 (Quinta)
4   |0          |5 (Sexta)

- *Turno*: Manhã (0); Vespertino (1); Noturno (2)
- *Dia da semana*: Domingo (0), Segunda (1), Terça (2), Quarta (3), Quinta (4), Sexta (5), Sábado (6)
- *Horário*: hora inicial (07:00), hora final (07:45)

* Um horário pode contemplar várias turmas
  
- *Turma* (esquema pedagógico): Id, Turno, Ano

1. Relação Horário e disponibilidade do professor
2. Quadro de horário