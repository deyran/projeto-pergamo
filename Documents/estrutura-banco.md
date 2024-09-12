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

* Registro de pessoas que estão vinculadas a escola e os processos administrativos

* ADM_EMPREGADOS - Pessoas da tabela EXT_PESSOAS que são empregados da escola

```
CREATE TABLE "ADM_EMPREGADOS" (
	"IdFuncao"	INTEGER NOT NULL,
	"IdPessoa"	INTEGER NOT NULL,
	"Ativo"	INTEGER,
	FOREIGN KEY("IdPessoa") REFERENCES "EXT_PESSOAS"("Id"),
	FOREIGN KEY("IdFuncao") REFERENCES "ADM_FUNCAO"("Id"),
	PRIMARY KEY("IdFuncao","IdPessoa")
)
```

* ADM_FUNCAO - Cargo ou função dos empregados da escola

```
CREATE TABLE "ADM_FUNCAO" (
	"Id"	INTEGER NOT NULL,
	"Descricao"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
)
```

## PEDAGÓGICO

### Classe

```
CREATE TABLE "PED_CLASSES" (
	"Id"		INTEGER,
	"Descricao"	TEXT NOT NULL,
	"Etapa"		TEXT NOT NULL,

	PRIMARY KEY("Id" AUTOINCREMENT)
)
```

#### Etapas

- Ensino infantil
- Anos iniciais
- Anos finais
- Ensino médio

### Turma

*Uma classe tem várias turmas*

```
CREATE TABLE "PED_TURMAS" (
	"Id"		INTEGER NOT NULL,
	"IdClasse"	INTEGER,
	"Turno"		INTEGER NOT NULL,
	"Ano"		INTEGER NOT NULL,
	"Descricao"	TEXT NOT NULL,

	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("IdClasse") REFERENCES "PED_CLASSES"("Id")
)
```

### Alunos

*Uma turma tem vários alunos*

```
CREATE TABLE "PED_TURMA_ALUNOS" (
	"Id"		INTEGER NOT NULL,
	"IdTurma"	INTEGER NOT NULL,
	"IdAluno"	INTEGER NOT NULL,
	
    PRIMARY KEY("Id" AUTOINCREMENT),
	
	FOREIGN KEY("IdAluno") REFERENCES "EXT_PESSOAS"("Id"),
	FOREIGN KEY("IdTurma") REFERENCES "PED_TURMAS"("Id")
)
```

### Disciplinas

```
CREATE TABLE "PED_DISCIPLINAS" (
	"Id"			INTEGER NOT NULL,
	"Descricao"		TEXT NOT NULL,
	"DescricaoAbv"	TEXT NOT NULL,
	"Cor"			TEXT NOT NULL,

    PRIMARY KEY("Id" AUTOINCREMENT),
)
```



### Classe | Disciplinas | Professores

* Uma classe tem várias disciplinas

* Disciplinas



* Classe & Disciplina - Uma classe tem várias disciplinas

```
CREATE TABLE "PED_CLASS_DISC" (
    "Id"	        INTEGER NOT NULL,
	"IdClasse"	    INTEGER NOT NULL,
	"IdDisciplina"	INTEGER NOT NULL,    

	PRIMARY KEY("Id" AUTOINCREMENT)
	FOREIGN KEY("IdClasse")     REFERENCES "PED_CLASSES"("Id"),
	FOREIGN KEY("IdDisciplina") REFERENCES "PED_DISCIPLINAS"("Id")
)
```

* 

## GRADE DE AULAS