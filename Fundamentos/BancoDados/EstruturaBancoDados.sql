CREATE TABLE jogos (
    id INT PRIMARY KEY IDENTITY(1, 1),
    categoria VARCHAR(40),
    nome VARCHAR (100)
);


-- DOUBLE: decimal
-- BIT: 1, 0 => boolean
-- DATE: Data
-- DATETIME2: Data e hora

--- CONSULTAR TODOS OS CAMPOS DA TELA
SELECT id, nome, categoria 
FROM jogos;

-- CONSULTAR A QUANTIDADE DE REGISTROS DA TABELA
SELECT COUNT(id) FROM jogos;

UPDATE jogos SET nome = 'Pedro', categoria = 'te ama muito! <3' where id = 10;


