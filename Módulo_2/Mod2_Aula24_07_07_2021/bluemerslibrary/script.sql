SELECT * FROM livros1 l 

CREATE TABLE Livros ( 
id SERIAL PRIMARY KEY,
editora VARCHAR(255) NOT NULL,
titulo VARCHAR(255) NOT NULL,
autor VARCHAR(255) NOT NULL,
numero_paginas VARCHAR(255) NOT NULL,
imagem_url VARCHAR(255) NOT NULL,
menor_preço VARCHAR(255) NOT NULL);

INSERT INTO livros (editora,titulo,autor,numero_paginas,imagem_url,menor_preço)
VALUES('Wrox', 'Professional C# 7 and .NET Core 2.0', 'Christian Nagel',
'2682','https://m.media-amazon.com/images/I/51fIfsdbeJL.jpg',
'https://www.amazon.com.br/Professional-NET-Core-2-0-English-ebook/dp/B07BN7V7N5/ref=sr_1_155?__mk_pt_BR=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=c%23+programming&qid=1625521519&s=books&sr=1-155
'),
(' Novatec Editora', 'Introdução à Programação com Python: Algoritmos e Lógica de Programação Para Iniciantes ', 'Nilo Ney Coutinho Menezes ',
'328','https://images-na.ssl-images-amazon.com/images/I/41qeEtBu02L._SX357_BO1,204,203,200_.jpg',
'https://www.amazon.com.br/Introdu%C3%A7%C3%A3o-Programa%C3%A7%C3%A3o-com-Python-Algoritmos/dp/8575227181/ref=asc_df_8575227181/?tag=googleshopp00-20'),
('Novatec Editora', 'Fundamentos de HTML5 e CSS3', 'Maurício Samy Silva',
'304','https://images-na.ssl-images-amazon.com/images/I/51lMsgv7s8L._SX357_BO1,204,203,200_.jpg',
'https://www.amazon.com.br/Fundamentos-Html5-Css3-Maur%C3%ADcio-Silva/dp/8575224387/ref=asc_df_8575224387/?tag=googleshopp00-20&linkCode=df0&hvadid='),
('Novatec Editora', 'Introdução à Linguagem SQL: Abordagem Prática Para Iniciantes', 'Thomas Nield',
'144','https://images-na.ssl-images-amazon.com/images/I/51Meg8yMu8L._SX347_BO1,204,203,200_.jpg',
'https://www.amazon.com.br/Introdu%C3%A7%C3%A3o-Linguagem-SQL-Abordagem-Iniciantes/dp/8575225014/ref=asc_df_8575225014/?tag=googleshopp00-20'),
('Alta Books', 'Código limpo: Habilidades práticas do Agile Software', 'Robert C. Martin',
'425','https://images-na.ssl-images-amazon.com/images/I/4153E2zZmTS._SX350_BO1,204,203,200_.jpg',
'https://www.amazon.com.br/C%C3%B3digo-limpo-Robert-C-Martin/dp/8576082675/ref=asc_df_8576082675/?tag=googleshopp00-20&linkCode=df0&hvadid=379792215563');


