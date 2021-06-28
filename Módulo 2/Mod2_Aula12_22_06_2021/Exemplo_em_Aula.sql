CREATE TABLE pessoas(
	id SERIAL NOT NULL,
	nome VARCHAR NOT NULL,
	sobrenome VARCHAR NOT NULL,
	idade INT,
	PRIMARY KEY (id)
);

/*
CREATE TABLE pedidos(
	id_pedido INT NOT NULL,
	data_pedido VARCHAR NOT NULL,
	descricaco VARCHAR NOT NULL,
	PRIMARY KEY (id_pedido, data_pedido)	
);

DROP TABLE pedidos; -- apagar uma tabela */

INSERT INTO pessoas (nome, sobrenome, idade)
VALUES  ('Eurico', 'Nicacio', 19),
		('Filipe', 'Mascarenhas', 15),
		('Daniel', 'Diniz', 28),
		('Ycaro', 'Batalha', 23),
		('Daniel', 'Diniz', 23),
		('Ycaro', 'Batalha', 21),
		('Nivia', 'Campos', 23),
		('Eduardo', 'Meireles', 35),
		('João', 'Veronez', 53),
		('João', 'da Silva', 22);

INSERT INTO pessoas (nome, sobrenome, idade)
VALUES  ('Silvio', 'Santos', 91),
		('Silvio', 'Sauro', 53);

-- inserindo multiplos registros em uma tabela
	
SELECT * FROM pessoas p; -- selecionar todos os registros da tabela

-- ######### MUITO CUIDADO AGORA! ##########
-- atualizar um registro do banco de dados
UPDATE pessoas -- nome da tabela 
SET sobrenome = 'Souza',  -- coluna1 = valor1
	idade = 48            -- coluna2 = valor 2
WHERE id = 12; -- ONDE id for igual a 12
-- WHERE -> condição 

-- ######### MUITO MAIS CUIDADO AGORA!!!!!!!!! #########
DELETE FROM pessoas -- nome da tabela
WHERE id >= 8 AND id <= 11;   -- condição - ONDE id for igual a 12

DELETE FROM pessoas
WHERE id BETWEEN 19 AND 27; -- condição - ENTRE 19 E 27

DELETE FROM pessoas -- nome da tabela
WHERE nome = 'Silvio' AND sobrenome = 'Sauro';   -- condição - ONDE id for igual a 12




INSERT INTO pessoas (nome, sobrenome, idade)
VALUES ((SELECT nome FROM pessoas WHERE id=5),
		(SELECT sobrenome FROM pessoas WHERE id=5),
		(SELECT idade FROM pessoas WHERE id=5));
		
UPDATE pessoas
SET nome='Paulo',
	sobrenome='Gabriel',
	idade=21
WHERE id=5;

SELECT nome, sobrenome FROM pessoas p ORDER BY id; -- SELECIONAR duas colunas, ORDENAR O id

SELECT * FROM pessoas WHERE idade > 30 
OR nome = 'Ycaro' OR sobrenome LIKE '%u%'; -- WHERE com diferentes condições

SELECT table_name FROM information_schema.tables WHERE table_schema='public'; -- traz todas as tabelas de um schema em um banco

INSERT INTO pessoas (nome, sobrenome, idade)
VALUES ('José', 'Da Silva', NULL); -- EXEMPLO INSERINDO 'NULL'

UPDATE pessoas
SET idade = 33
WHERE idade IS NULL; -- EXEMPLO ALTERANDO 'NULL'





SELECT DISTINCT (nome) FROM pessoas; -- traz todos os nomes distintos/unicos

SELECT * FROM pessoas p LIMIT 3;









SELECT * FROM pessoas WHERE nome = 'Eurico';


SELECT * FROM pessoas WHERE idade < 50
ORDER BY nome ASC; -- ascending

SELECT * FROM pessoas WHERE idade < 50
ORDER BY nome ASC LIMIT 3;

SELECT * FROM pessoas WHERE idade < 50
ORDER BY nome DESC; -- descending

SELECT idade, nome, sobrenome FROM pessoas WHERE idade < 50
ORDER BY idade DESC; -- traz idade, nome e sobrenome com idade < 50, ordenados por idade desc

SELECT COUNT(*) FROM pessoas; -- conta os registros da tabela



