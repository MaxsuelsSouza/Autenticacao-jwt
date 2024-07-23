Build started...
Build succeeded.
The Entity Framework tools version '6.0.21' is older than that of the runtime '8.0.7'. Update the tools for the latest features and bug fixes. See https://aka.ms/AAc1fbw for more information.
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'chat') THEN
        CREATE SCHEMA chat;
    END IF;
END $EF$;

CREATE TABLE chat.usuarios (
    "UsuarioId" uuid NOT NULL,
    "Nome" character varying(300) NOT NULL,
    "NomeUsuario" character varying(300) NOT NULL,
    "Sobrenome" character varying(300) NOT NULL,
    "Idade" integer NOT NULL,
    "Email" character varying(255) NOT NULL,
    "Senha" text NOT NULL,
    CONSTRAINT "PK_usuarios" PRIMARY KEY ("UsuarioId")
);

CREATE UNIQUE INDEX "IX_usuarios_Email" ON chat.usuarios ("Email");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240723000316_migracaoIncial', '8.0.7');

COMMIT;


