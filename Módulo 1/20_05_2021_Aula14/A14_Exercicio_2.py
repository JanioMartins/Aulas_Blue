"""
#02 - Utilizando estruturas de repetição com variável de controle, 
# faça um programa que receba uma string com uma frase informada 
# pelo usuário e conte quantas vezes aparece as vogais a,e,i,o,u e 
# mostre na tela, depois mostre na tela essa mesma frase sem nenhuma vogal.
"""
print()
print( "=--=" * 25)
print()


frase = input("Digite uma frase: ").upper()
vogais = "AEIOU"
#substituição de vogas por "aspas" vazias
consoantes = frase.replace('A','').replace('E','').replace('I','').replace('O','').replace('U','')
cont = 0

#Laço para contar as vogais inseridas na frase.
for letras in frase:
    if letras in vogais:
        print(letras, end = " - ")
        cont += 1

print(f" {cont} vogais!")
print(consoantes)

print()
print( "=--=" * 25)
print()