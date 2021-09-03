"""
#05 - Refatore o exercício 2, para que uma função receba a frase, 
# faça todo o tratamento necessário e retorne o resultado. 
# Depois mostre na tela o resultado e a quantidade de letras foram retiradas da frase original.
"""

print()
print( "=--=" * 25)
print()

def ref(frase):
    vogais = "AEIOU"
    #substituição de vogas por "aspas" vazias
    consoantes = frase.replace('A','').replace('E','').replace('I','').replace('O','').replace('U','')
    cont = 0

    #Laço para contar as vogais inseridas na frase.
    for letras in frase:
        if letras in vogais:
            cont += 1


    print(f" {cont} vogais!")
    print(consoantes)
    print(f"foram cortadas {cont} letras da frase original.") #mostrando na tela quantidade de letras retiradas da frase.

frase = input("Digite uma frase: ").upper()
ref(frase)


print()
print( "=--=" * 25)
print()