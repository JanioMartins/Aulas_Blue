# Codelab - Aula 15.1

Agora que você conhece o essencial sobre SQL, `criação de tabelas; tipos de dados para colunas; primary keys; foreign keys; join table; SQL joins`, é possível imaginar vários tipos de interações e relações entre essas informações.

1. Pegue a aplicação que você construiu nos últimos codelabs e extraia os ER Diagram do DBeaver.
2. Extraia o DDL (Data Definition Language) da sua aplicação.
   - Para fazer isso no DBeaver, selecione todas as tabelas da sua base de dados, clique com o botão direito em cima da seleção e navegue até `Genere SQL > DDL`. Salve o conteúdo em arquivo com extensão `.sql`.
3. Extraia os dados da sua aplicação, combinados em um único arquivo.
   - Para isso, selecione todas as tabelas e clique na opção `Export Data`.
     - Na primeira tela, marque a opção `SQL`;
     - Mantenha a segunda tela padrão;
     - Na terceira tela, marque a opção `Write to the single file`;
     - 
4. Separe em uma pasta o ER Diagram extraído do DBeaver e o DDL extraído da aplicação.

5. Vamos praticar um pouquinho o seu planejamento de banco de dados e pensar em uma nova base para resolver um outro problema?
   - **Problema:** Criar um banco de dados em que o usuário faça uma relação de filmes que deseja adquirir e descreva os personagens que fazem parte do filme. Esse banco precisa armazenar os usuários (nome), filmes (nome, imagem_url, orçamento, ano) e personagens (nome e imagem_url) 

   - **Desafio extra:** utilizando qualquer software de construção de diagramas a sua escolha (existem vários disponíveis), faça o planejamento da sua nova base de dados, antes de começar a criação das tabelas e colunas.
   - Crie as tabelas com as devidas colunas, `primary keys` e `foreign keys`.
   - Salve todos os diagramas e arquivos de referência em uma nova pasta.
