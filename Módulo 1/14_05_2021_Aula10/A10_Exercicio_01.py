# Exercício 0 – Crie um laço while que vai pedir para o usuário dois números e faça a soma dos dois. 
# Enquanto a soma não for 50, ele deve continuar repetindo.

num1 = int(input("digite o 1° número: "))
num2 = int(input("digite o 2° número: "))

soma = num1 + num2

var1 = 50

while soma != var1:
    print("O valor da soma NÃO é 50!!!")
    num1 = int(input("digite novamente o 1° número: "))
    num2 = int(input("digite novamente o 2° número: "))

print("O valor da soma É 50!!!")