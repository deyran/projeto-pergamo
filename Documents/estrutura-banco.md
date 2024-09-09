# Estrutura de banco de dados

## Registros externos

## Pedagógico

### Classe e Turmas

* Uma classe tem várias turmas

* PED_CLASSES
```
CREATE TABLE "PED_CLASSES" (
	"Id"	INTEGER,
	"Descricao"	TEXT NOT NULL,
	"Composicao"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
)
```

* PED_TURMAS

```
CREATE TABLE "PED_TURMAS" (
	"Id"	INTEGER NOT NULL,
	"IdClasse"	INTEGER,
	"Turno"	INTEGER NOT NULL,
	"Ano"	INTEGER NOT NULL,
	"Descricao"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("IdClasse") REFERENCES "PED_CLASSES"("Id")
)
```

### Turma e Alunos

* Uma turma tem vários alunos

* PED_TURMA_ALUNOS

```
CREATE TABLE "PED_TURMA_ALUNOS" (
	"Id"	INTEGER NOT NULL,
	"IdTurma"	INTEGER NOT NULL,
	"IdAluno"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("IdAluno") REFERENCES "REG_PESSOAS"("Id"),
	FOREIGN KEY("IdTurma") REFERENCES "PED_TURMAS"("Id")
)
```