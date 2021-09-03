"""
#06 - Utilizando listas faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

   # "Telefonou para a vítima?"

   # "Esteve no local do crime?"

   # "Mora perto da vítima?"

   # "Devia para a vítima?"

   # "Já trabalhou com a vítima?" 

# O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. 

   # Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita",

   # Entre 3 e 4 como "Cúmplice" e 5 como "Assassino". 

   # Caso contrário, ele será classificado como "Inocente".
"""
print()
print( "=--=" * 25)
print()

l_resp = []

l_perg = ["Telefonou para a vítima? ", "Esteve no local do crime? ", 
"Mora perto da vítima? ", "Devia para a vítima? ", "Já trabalhou com a vítima? "]

cont = 0

#laço para realizar as perguntas da lista.
for l_resp in l_perg:
    a = input(l_resp).lower()
    if a == "sim":
        cont += 1 #contador de respostas sim para definir o 

print()
print( "=--=" * 25)
print()

if cont < 2:
    print("Inocente")
elif cont == 2 :
    print("Suspeito")
elif cont <= 4:
    print("Cúmplice")
else:
    print("Assassino")

print()
print( "=--=" * 25)
print()