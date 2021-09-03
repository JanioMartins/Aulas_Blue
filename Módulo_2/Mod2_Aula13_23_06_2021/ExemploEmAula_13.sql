CREATE TABLE produtos_tipo(
	idTipo SERIAL PRIMARY KEY,
	descricaoTipo VARCHAR NOT NULL,
);

CREATE TABLE produtos(
	idProd SERIAL PRIMARY KEY,
	descricaoProd VARCHAR NOT NULL,
	precoProd DECIMAL(10,2),
	tipo INT NOT NULL REFERENCES produtos_tipo(idTipo)
);

INSERT INTO produtos_tipo (descricaotipo)
VALUES ('Computador'), 
       ('Impressora'),  
       ('Smartphone');

INSERT INTO produtos ( descricaotipo, precoprod, tipo)
VALUES ('Desktop', 1200.00, 1),
	   ('Notebook', 4000.00, 1), 
	   ('Impressora Lesar'1500.00, 2), 
	   ('Impressora Jato de Tinta', 500.00, 2), 
	   ('HeadSet Gamer', 300.00, NULL);
	  
	  
SELECT * FROM produtos

