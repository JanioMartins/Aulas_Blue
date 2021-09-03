"""
#07 - Crie um programa onde o usuário possa digitar sete valores numéricos e 
# cadastre-os em uma lista única que mantenha separados os valores pares e ímpares. 
# No final, mostre os valores pares e ímpares em ordem crescente.
"""

print()
print( "=--=" * 25)
print()

pa = [] #lista para armazenar pares.
im = [] #Lita para armazenas impares.
lista = [pa, im] #Lista com pares e impares.

#Laço para pedir os números ao usuário.
for v in range(7):
    v = int(input("Digite um número: "))
    if (v % 2) == 0:
        pa.append(v)
    else:
        im.append(v)


print()
print( "=--=" * 25)
print()


print("Listas separadas em PAR e IMPAR em uma lista única, e organizadas em ordem crescente.")
pa.sort()
im.sort()
print(lista)

print()
print( "=--=" * 25)
print()
