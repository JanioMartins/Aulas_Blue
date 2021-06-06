"""
#03 - Utilizando estruturas de repetição com teste lógico, 
# faça um programa que peça uma senha para iniciar seu processamento, 
# só deixe o usuário continuar se a senha estiver correta, 
# após entrar dê boas vindas a seu usuário e apresente a ele o jogo da advinhação, 
# onde o computador vai “pensar” em um número inteiro entre 0 e 20. 
# O jogador vai tentar adivinhar qual número foi escolhido até acertar, 
# a cada palpite do usuário diga a ele se o número escolhido pelo computador 
# é maior ou menor ao que ele palpitou, no final mostre quantos palpites foram necessários para vencer.
"""

print()
print( "=--=" * 25)
print()

cadastre = input("Cadastre uma senha senha: ")
senha_registrada = cadastre

senha_digitada = input("senha: ")

while senha_digitada != senha_registrada:
    print("Senha inválida, Digite novamente!")
    senha_digitada = input("senha: ")

print("Efetuando login...")

print()
print( "=--=" * 25)
print()
print("                                       BEM VINDO AO JOGO DE ADVINHAÇÃO!                                           ")
print("          A máquina escolheu um número de 1 a 20, tente acertá-lo em menos tentativas possíveis.                  ")
print()
print( "=--=" * 25)
print()

from random import randint
maquina = randint(0, 21) #sorteio de número pelo programa
igual = False #condição fixa para validar o while.
tentativas = 0 #inicio do contador

while not igual:
    usuario = int(input("Digite o seu palpite de 1 a 20: "))
    tentativas += 1 # alterando o contador a cada tentativa do usuário.
    if usuario == maquina:
        igual = True # mudança da condição após o acerto do número sorteado.
    else: 
        if usuario < maquina:
            print("o seu palpite de", usuario, "foi menor do que o palpite da máquina") 
        elif usuario > maquina:
            print("o seu palpite de", usuario, "foi maior do que o palpite da máquina") 
    
print()
print( "=--=" * 25)
print()
print("PARABÉNS! VOCÊ ACERTOU!")
print("O seu palpite foi IGUAL ao palpite de", maquina, "da máquina")
print("Você acertou o palpite de", maquina, "da máquina com", tentativas, "tentativas!")

print()
print( "=--=" * 25)
print()    
print("FIM")                                            
print()
print( "=--=" * 25)
print()