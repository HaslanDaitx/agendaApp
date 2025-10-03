
CREATE DATABASE agenda_2.0;



\c agenda_2.0;





CREATE TABLE log_operacoes (
    id_log SERIAL PRIMARY KEY,
    data_hora TIMESTAMP NOT NULL DEFAULT NOW(),
    tipo_operacao VARCHAR(10) NOT NULL,
    dados_operacao JSONB
);



CREATE TABLE cadastro (
    nome VARCHAR(255) NOT NULL,
    telefone NUMERIC(15) UNIQUE NOT NULL CHECK (telefone > 0)
);




CREATE OR REPLACE FUNCTION log_cadastro_op()
RETURNS TRIGGER AS $$
BEGIN
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO log_operacoes (tipo_operacao) VALUES ('Insert');
        RETURN NEW;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO log_operacoes (tipo_operacao) VALUES ('Update');
        RETURN NEW;
    ELSIF (TG_OP = 'DELETE') THEN
        INSERT INTO log_operacoes (tipo_operacao) VALUES ('Delete');
        RETURN OLD;
    END IF;
END;
$$ LANGUAGE plpgsql;



CREATE TRIGGER log_op AFTER INSERT OR UPDATE OR DELETE ON cadastro
FOR EACH ROW EXECUTE FUNCTION log_cadastro_op();