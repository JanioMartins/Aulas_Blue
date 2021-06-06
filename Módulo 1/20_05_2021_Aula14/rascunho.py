"""

n1 = input('Digite o 1° número: ')
n2 = input("Digite o 2° número: ")

while n1 != int != n2 or n1 == 0 == n2:
    print('Null!, Escolha um número!!')
    n1 = input('Digite o 1° número: ')
    n2 = input("Digite o 2° número: ")
   
soma = int(n1 + n2)
print("               - A Soma de", n1, "e", n2, "é igual a", n1 + n2)
multiplicacao = int(n1 * n2)
print(f"               - A Multiplicação de {n1:.0f} e {n2:.0f} é igual a {n1 * n2:.0f}")
divisao = n1 // n2
print(f"               - A divisão de {n1:.0f} e {n2:.0f} é igual a {n1 // n2:.0f}")
maior1 = n1 > n2
print(f"               - O número {n1:.0f} é maior que o número {n2:.0f}")
maior2 = n1 < n2
print(f"               - O número {n2:.0f} é maior que o número {n1:.0f}")
impar = soma % 0
print(f"               - A soma de {n1:.0f} e {n2:.0f} retorna um número IMPAR")
par = soma % 1
print(f"               - A soma de {n1:.0f} e {n2:.0f} retorna um número PAR")



if multiplicacao > 40:
    print(f"               - A divisão de {multiplicacao:.0f} pelo resultado da divisão de {n1:.0f} dividido por {n2:.0f} é igual a {multiplicacao // divisao:.0f}")
else:
    print(f"               - A multiplicação de {n1:.0f} e {n2:.0f} retornou o número {multiplicacao:.0f}, que é menor do que 40")
"""
"""
login=input("Crie seu usuário: ")
senha=input("Crie a sua senha: ")
print(">>>>>>>>>>> Agora vamos acessar o sistema!! <<<<<<<<<<<<<")
usuario=input("Digite o login: ")
while usuario !=login:
    usuario=input("Usuário incorreto,digite novamente:")
print(">>>>>>>Usuario correto!!<<<<<<<<")
sn=input("Digite a senha: ")
while sn!=senha:
    sn=input("Senha incorreta,digite novamente!! ")
print("Senha correta,acesso liberado!!")
print(f">>>>>>Olá {login}!!Seja bem vindo ao jogo da adivinhação!!<<<<<<<")
"""
"""
import random
palpite=0
numero = random.randint(0,21)

login=input("Crie seu usuário: ")
senha=input("Crie a sua senha: ")
print(">>>>>>>>>>> Agora vamos acessar o sistema!! <<<<<<<<<<<<<")
usuario=input("Digite o login: ")
while usuario !=login:
    usuario=input("Usuário incorreto,digite novamente:")
print(">>>>>>>Usuario correto!!<<<<<<<<")
sn=input("Digite a senha: ")
while sn!=senha:
    sn=input("Senha incorreta,digite novamente!! ")
print("Senha correta,acesso liberado!!")
print(f">>>>>>Olá {login}!!Seja bem vindo ao jogo da adivinhação!!<<<<<<<")
print()
jogador=int(input("Que número você acha que está guardado?:"))
palpite+=1
if jogador<numero:
    print('Errou!!O seu palpite foi menor que o número guardado!!')
    print(int(input("Tente outra vez,que número você escolhe?:")))
    palpite+=1
if jogador>numero:
    print('Acertou!!O seu palpite foi maior que o número guardado!!')
    palpite+=1

print(f'Parabéns {login} você acertou na {palpite} tentativa!!')
"""
"""
import random
palpite=0
numero = random.randint(0,21)

login=input("Crie seu usuário: ")
senha=input("Crie a sua senha: ")
print(">>>>>>>>>>> Agora vamos acessar o sistema!! <<<<<<<<<<<<<")
usuario=input("Digite o login: ")
while usuario !=login:
    usuario=input("Usuário incorreto,digite novamente:")
print(">>>>>>>Usuario correto!!<<<<<<<<")
sn=input("Digite a senha: ")
while sn!=senha:
    sn=input("Senha incorreta,digite novamente!! ")
print("Senha correta,acesso liberado!!")
print(f">>>>>>Olá {login}!!Seja bem vindo ao jogo da adivinhação!!<<<<<<<")
print()
palpite=int(input("Que número você acha que está guardado?:"))
palpite+=1
if palpite>numero:
    print('Errou!!O seu palpite foi maior que o número guardado!!')
    print(int(input("Tente outra vez,que número você escolhe?:")))
    #palpite+=1
if palpite<numero:
    print('Errou!!O seu palpite foi menor que o número guardado!!')
    print(int(input("Tente outra vez,que numero você escolhe?:")))
    #palpite+=1
else:
    print(f'Parabéns {login} você acertou na {palpite} tentativa!!')
    """
""""
from random import randint
maquina = randint(0, 21)
print(maquina)
palpite = int(input("Digite o seu palpite de 1 a 20: "))


while palpite < maquina:
    print("TENTE NOVAMENTE!")
    print("O seu palpite de", palpite, "foi inferior ao palpite de",maquina, "da máquina ")
    palpite = int(input("Digite novamente o seu palpite de 1 a 20: "))

    if palpite > maquina:
        print("TENTE NOVAMENTE")
        print("O seu palpite de", palpite, "foi superior ao palpite de", maquina, "da máquina")
        palpite = int(input("Digite novamente o seu palpite de 1 a 20: "))

if palpite == maquina:
    print("PARABENS VC VENCEU!")
    print("O seu palpite de", palpite, "foi igual ao palpite de", maquina, "da máquina ")   
"""
"""
lista = [[], []]
for v in range(7):
    v = int(input("Digite um número: "))
    if (v % 2) == 0:
        lista[0].append(v)
    else:
        lista[1].append(v)

print(lista)
"""




class Herói():
    def __init__(self, nome, idade, peso):
        self.nome = nome
        self.idade = idade
        self.peso = peso

    def engordar(self, peso):
        self.peso += peso

a = Herói('Capitão América',30, 85)
print(vars(a))
a.engordar(10)
#print(vars(a))


class Pessoa():
    def __init__(self, nome, altura, peso):
        self.nome = nome
        self.altura = altura
        self.peso = peso

    def emagrecer(self, peso):
        self.peso -= peso

a = Pessoa('Steve Rogers',1.80, 90)
print(vars(a))
a.emagrecer(10)
#print(vars(a))
