# Exercício 1 - Escreva um programa que pede a senha ao usuário, 
# e só sai do looping quando digitarem corretamente a senha.

#variáveis
senha = "azul21"
valid = input("Senha: ")

#bloco while (execução)
while valid != senha:
    print("Senha incorreta!")
    valid = input("Senha: ")

print("Senha correta!")