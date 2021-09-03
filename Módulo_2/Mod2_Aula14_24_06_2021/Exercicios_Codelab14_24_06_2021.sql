
<!-- Exercícios

<!-- 1)Listar o nome, sobrenome e email de todos os funcionários
SELECT nome, sobrenome, email FROM funcionarios f;

<!-- 2)Listar o nome, sobrenome e email de todos os funcionários que são
<!-- representantes de vendas
SELECT f.nome, f.sobrenome , f.email, f.cargo='Sales Rep' FROM funcionarios f; 

<!-- 3)Listar todos os cargos (sem repetir)
SELECT DISTINCT cargo FROM funcionarios f;

<!-- 4)Listar todas as cidades (sem repetir) em que a empresa possui lojas
SELECT DISTINCT cidade FROM lojas l;

<!-- 5)Listar o nome, sobrenome e email , cidade, país e telefone da loja do
<!-- presidente da empresa
SELECT f.nome,f.sobrenome, f.email, l.cidade, l.pais, l.telefone FROM funcionarios f , lojas l
INNER JOIN f.cargo = f.cargo('President') ;


<!-- 6)Listar o produto com o maior preço
SELECT * FROM produtos p 
ORDER BY p.precosugerido DESC;

<!-- 7)Listar o produto com menor preço
SELECT * FROM produtos p 
ORDER BY p.precosugerido ASC;

<!-- 8)Listar o produto com menor quantidade em estoque
SELECT * FROM produtos p 
ORDER BY p.qtdestoque ASC;

<!-- 9)Listar o produto com maior quantidade em estoque
SELECT * FROM produtos p 
ORDER BY p.qtdestoque DESC;

<!-- 10)Listar produto e quantidade de vendas daquele produto
SELECT p.nomeproduto, d.quantidadepedida FROM produtos p, detalhespedidos d;





<!-- Desafio

<!-- 1)Listar os clientes com maior quantidade de vendas. Exibir: Nome,
<!-- Sobrenome, Cidade e Estado do Cliente e a quantidade de vendas dele


<!-- 2)Listar os produtos com maior quantidade de vendas. Exibir: Nome do
<!-- Produto, Descrição da Linha do Produto, Preço do Produto e Quantidade de
<!-- Vendas


<!-- 3)Listar os funcionários que venderam mais (em quantidade). Exibir: Nome do
<!-- funcionário, sobrenome, email e o superior dele.


<!-- 4)Listar os clientes que mais gastaram ($). Exibir: Nome, Sobrenome, Cidade e
<!-- Estado do Cliente e o limite de créditos deles


<!-- 5)Montar um relatório em que conste todos os dados dos empregados
<!-- (inclusive da loja a que eles pertencem) e os clientes que esses atendem
<!-- (inclua neste relatório também todos os dados dos clientes).





