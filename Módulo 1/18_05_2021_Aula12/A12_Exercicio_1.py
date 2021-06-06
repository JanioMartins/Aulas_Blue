'''
Exercício Treino - Crie um dicionário em que suas chaves serão os números 1, 4, 5, 6,
7, e 9 (que podem ser armazenados em uma lista) e seus valores correspondentes
aos quadrados desses números.
{1: 1, 4: 16, 5: 25, 6: 36, 7: 49, 9: 81} 
'''

n1 = [1, 4, 5, 6, 7, 9]

n2 = [(n1[0], n1[0] * n1[0]), (n1[1], n1[1] ** 2), (n1[2], n1[2] * n1[2]), 
(n1[3], n1[3] ** 2), (n1[4], n1[4] * n1[4]), (n1[5], n1[5] ** 2)]

quadrados = dict(n2)

print(quadrados)