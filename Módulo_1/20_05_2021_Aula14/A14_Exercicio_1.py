"""
#01 - Utilizando estruturas condicionais 
# faça um programa que pergunte ao usuário dois números e mostre:

   # A soma deles;

   # A multiplicação entre eles;

   # A divisão inteira deles;

   # Mostre na tela qual é o maior;

   # Verifique se o resultado da soma é par ou impar e mostre na tela;

   # Se a multiplicação entre eles for maior que 40, 
   # divida pelo resultado da divisão inteira e mostre o resultado na tela. Se não, 
   # mostre que a multiplicação não foi maior que 40.
   """

print()
print( "-==-" * 25)
print()
#inputs para coletar os números junto ao usuário.
n1 = float(input("Digite o 1° número: "))
n2 = float(input("Digite o 2° número: "))
print()
print( "=--=" * 25)
print()

#validação para o caso de escolhido o número 0.
while n1 == 0 == n2:
    print("Digite um número diferente de 0!")
    n1 = float(input("Digite o 1° número: "))
    n2 = float(input("Digite o 2° número: ")) 

#Condições para retornar os resultados solicitados em tela.
if n1 + n2:
    print(f"               - A Soma de {n1:.0f} e {n2:.0f} é igual a {n1 + n2:.0f}")
if n1 * n2:
    print(f"               - A Multiplicação de {n1:.0f} e {n2:.0f} é igual a {n1 * n2:.0f}")
if n1 // n2:
    print(f"               - A divisão de {n1:.0f} e {n2:.0f} é igual a {n1 // n2:.0f}")
if n1 > n2:
    print(f"               - O número {n1:.0f} é maior que o número {n2:.0f}")
if n1 < n2:
    print(f"               - O número {n2:.0f} é maior que o número {n1:.0f}")

soma = n1 + n2
if soma % 2:
    print(f"               - A soma de {n1:.0f} e {n2:.0f} retorna um número IMPAR")
else:
    print(f"               - A soma de {n1:.0f} e {n2:.0f} retorna um número PAR")

multiplicacao = n1 * n2
divisao = n1 // n2
if multiplicacao > 40:
    print(f"               - A divisão de {multiplicacao:.0f} pelo resultado da divisão de {n1:.0f} dividido por {n2:.0f} é igual a {multiplicacao // divisao:.0f}")
else:
    print(f"               - A multiplicação de {n1:.0f} e {n2:.0f} retornou o número {multiplicacao:.0f}, que é menor do que 40")

print()
print( "=--=" * 25)
print()