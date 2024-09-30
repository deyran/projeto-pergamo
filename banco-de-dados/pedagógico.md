# PEDAGÓGICO

## Classe

```
CREATE TABLE "PED_CLASSES" 
(
	"Id"		INTEGER,
	"Descricao"	TEXT NOT NULL,
	"IdEtapa	INTEGER,

	PRIMARY KEY("Id" AUTOINCREMENT)
    FOREIGN KEY("IdEtapa") REFERENCES "PED_CLASSES_ETAPA"("Id"),    
)
```

### Etapa

```
CREATE TABLE PED_CLASSES_ETAPA
(
    "Id"		INTEGER,
    "Descricao"	TEXT NOT NULL,

    PRIMARY KEY("Id" AUTOINCREMENT)
)

INSERT INTO PED_CLASSES_ETAPA ("Descricao") VALUES ('Ensino infantil');
INSERT INTO PED_CLASSES_ETAPA ("Descricao") VALUES ('Anos iniciais');
INSERT INTO PED_CLASSES_ETAPA ("Descricao") VALUES ('Anos finais');
INSERT INTO PED_CLASSES_ETAPA ("Descricao") VALUES ('Ensino médio');

```