# ESTRUTURA DO BANDO DE DADOS

## REGISTRO EXTERNOS

* Registros externos Representam todos os dodos obtidos fora da realidade da escola

* EXT_PESSOAS - Todas as pessoas, física ou jurídica, que estão vinculadas com a escola

```
CREATE TABLE "EXT_PESSOAS" (
	"Id"	INTEGER NOT NULL,
	"Nome"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
)
```

* EXT_PESS_VINC - Mapeamento que resgistro como as pessoas estão vinculadas

```
CREATE TABLE "EXT_PESS_VINC" (
	"IdPess1"	INTEGER,
	"IdPess2"	INTEGER,
	"Tipo"	INTEGER,
	FOREIGN KEY("IdPess1") REFERENCES "EXT_PESSOAS"("Id"),
	FOREIGN KEY("IdPess2") REFERENCES "EXT_PESSOAS"("Id"),
	PRIMARY KEY("IdPessoa","IdAluno")
)
```

## ADMINISTRATIVO

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
	FOREIGN KEY("IdAluno") REFERENCES "EXT_PESSOAS"("Id"),
	FOREIGN KEY("IdTurma") REFERENCES "PED_TURMAS"("Id")
)
```