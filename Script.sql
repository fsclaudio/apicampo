CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Tarefas" (
    id uuid NOT NULL,
    "UsuarioId" uuid NOT NULL,
    nome text NOT NULL,
    "Concluida" boolean NOT NULL,
    CONSTRAINT "PK_Tarefas" PRIMARY KEY (id)
);

CREATE TABLE "Usuarios" (
    id uuid NOT NULL,
    nome text NOT NULL,
    email text NOT NULL,
    senha text NOT NULL,
    CONSTRAINT "PK_Usuarios" PRIMARY KEY (id)
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200722181736_InitialCreate', '3.1.4');

