'''
Exercício Treino - Crie um dicionário em que suas chaves correspondem a números
inteiros entre [1, 10] e cada valor associado é o número ao quadrado.
{1: 1, 2: 4, 3: 9, 4: 16, 5: 25, 6: 36, 7: 49, 8: 64, 9: 81, 10: 100}
'''

n1 = list(range(1,11))
for i in n1:
    n2 = [(n1[0], n1[0] * n1[0]), (n1[1], n1[1] ** 2), (n1[2], n1[2] * n1[2]), 
    (n1[3], n1[3] ** 2), (n1[4], n1[4] * n1[4]), (n1[5], n1[5] ** 2), 
    (n1[6], n1[6] ** 2), (n1[7], n1[7] ** 2), (n1[8], n1[8] ** 2), (n1[9], n1[9] ** 2)]

quad = dict(n2)

print(quad)

'''
n1 = list(range(1,11))
print(n1)
for i in n1:
    n2 = i, i ** 2
    n3 = []
    n3.append(n2)
    print(n3, end=",")
    # n4 = dict(n3)
    # print(n4)
'''  
   
'''
n1 = list(range(1,11))
print(n1)
for i in n1:
    n1 =  i, i ** 2
    n2 = []
    n2.append(n1)
    print(n2, end=",")
'''
'''
n1 = list(range(1,11))
for i in n1:
    n1 =  i, i ** 2
    n2 = []
    n2.append(n1)
    print(n2, end=",")
'''