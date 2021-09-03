INSERT INTO public.filmes (nome,imagem_url,orcamento,adicionado_por_usuario_id,ano) VALUES
	 ('Harry Potter e a Pedra Filosofal','url_capa_filme',1500.00,1,2010),
	 ('Senhor dos Anéis: A Sociedade do Anel','url_capa_filme',2500.00,2,2011),
	 ('Django Livre','url_capa_filme',1200.00,3,2012),
	 ('Pokémon - O Filme 2000','url_capa_filme',4000.00,4,2013),
	 ('Star Wars: O Retorno do Jedi','url_capa_filme',3000.00,3,2014),
	 ('Minha Mãe é Uma Peça','url_capa_filme',1700.00,2,2015),
	 ('As Branquelas','url_capa_filme',2600.00,1,2016),
	 ('Venom','url_capa_filme',3400.00,2,2017),
	 ('Rambo: Até o Fim','url_capa_filme',1800.00,3,2018),
	 ('Senhor dos Anéis: A Sociedade do Anel','url_capa_filme',2600.00,1,2019);
INSERT INTO public.filmes (nome,imagem_url,orcamento,adicionado_por_usuario_id,ano) VALUES
	 ('Harry Potter e o Prisioneiro de Azkaban','url_capa_filme',1800.00,3,2020);INSERT INTO public.filmes_personagens (filme_id,personagem_id) VALUES
	 (1,1),
	 (1,2),
	 (1,3),
	 (1,4),
	 (1,5),
	 (1,6),
	 (2,7),
	 (2,8),
	 (2,9),
	 (2,10);
INSERT INTO public.filmes_personagens (filme_id,personagem_id) VALUES
	 (5,11),
	 (5,12),
	 (5,13),
	 (5,14),
	 (5,15),
	 (5,16),
	 (5,17),
	 (11,18),
	 (10,1),
	 (10,2);
INSERT INTO public.filmes_personagens (filme_id,personagem_id) VALUES
	 (10,3),
	 (10,4),
	 (10,5),
	 (10,6),
	 (11,7),
	 (11,8),
	 (11,9),
	 (11,10);INSERT INTO public.personagens (nome,imagem_url) VALUES
	 ('Harry Potter','url_personagem'),
	 ('Hermione Granger','url_personagem'),
	 ('Rony Weasley','url_personagem'),
	 ('Severo Snape','url_personagem'),
	 ('Alvo Dumbledore','url_personagem'),
	 ('Lord Voldemort','url_personagem'),
	 ('Frodo','url_personagem'),
	 ('Bilbo','url_personagem'),
	 ('Gandalf','url_personagem'),
	 ('Golum','url_personagem');
INSERT INTO public.personagens (nome,imagem_url) VALUES
	 ('Chewbacca','url_personagem'),
	 ('Darth Vader','url_personagem'),
	 ('Luke Skywalker','url_personagem'),
	 ('Leia Organa','url_personagem'),
	 ('Obi-Wan Kenobi','url_personagem'),
	 ('Han Solo','url_personagem'),
	 ('R2-D2','url_personagem'),
	 ('Sirius Black','url_personagem');INSERT INTO public.usuarios (nome) VALUES
	 ('Paulo Salvatore'),
	 ('João Souza'),
	 ('Mariana Oliveira'),
	 ('Júlia Soares');