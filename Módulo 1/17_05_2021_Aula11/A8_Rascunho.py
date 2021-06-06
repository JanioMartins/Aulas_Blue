

lista_contatos = [("Carlos", "98670-0897"),("Adriano", 
"98695-0897"),("Ana", "97470-0897"),
("Janaina", "98670-9097"),("Maria", "98670-0891")]


'''
print(lista_contatos)
print(lista_contatos[0])
print(lista_contatos[0][0])

contatos = dict(lista_contatos)
print(contatos)

print(contatos.get("Janaina"))
print(contatos.get('Janio', 'Nome não encontrado'))
'''

vingadores = [('Chris Evans', 'Capitão América'), ('Mark Ruffalo', 'Hulk'), ('Tom Hiddleston', 'Loki'), 
('Chris Hemworth', 'Thor'), ('Robert Downey Jr', 'Homem de Ferro'), ('Scarlett Johansson', 'Viúva Negra')]
convert = dict(vingadores)
#busca = input("Qual o ator?: ")
#print(convert.get(busca, "Ator não encontrado"))

print(convert.keys())
print(convert.values())

