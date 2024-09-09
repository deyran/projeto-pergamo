# Estrutura de banco de dados

## Classe e Turmas

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