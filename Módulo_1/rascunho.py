
"""
nascimento = input("Digite sua data de nascimento (DD/MM/AAAA): ")
dia, mesDat, ano = nascimento[:2], nascimento[3:5], nascimento[6:10]
res = dia + mesDat + ano
m = int(res[2:4])

mesesExt = ("Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", 
"Agosto", "Setembro", "Outubro", "Novembro", "Dezembro")


print(dia, "de", mesesExt,"de", ano)
print(dia, "de", mesesExt[m - 1],"de", ano)
"""

"""
jogador={input("Digite o nome do jogador: ").title()}
qtd_partidas=int(input('Digite a quantidade de partidas jogadas: '))
total_gols=0

for partida in range(qtd_partidas):
    gol_partida=int(input(f'Quantos gols {jogador} fez na partida {partida+1}?'))
    gols={partida:gol_partida}
    print(f'Na partida {partida+1} o jogador {jogador} fez {gol_partida} gol(s)!!')
total_gols+=gol_partida
print(f'O jogador {jogador} fez um total de',total_gols,'gol(s)!!')(editado)
{8:54}
"""



"""
n1 = int(input('Digite o 1° número: '))
n2 = int(input("Digite o 2° número: "))

if n1 != int != n2 or n1 == 0 == n2:
    print('Null!')
    n1 = input('Digite o 1° número: ')
    n2 = input("Digite o 2° número: ")

soma = int(n1 + n2)
print("               - A Soma de", n1, "e", n2, "é igual a", n1 + n2)
"""
"""
frase=input("Digite uma frase: ").lower()
vogais=0
for letra in frase:
    if letra in 'aeiou':
        vogais+=1
print(f'As vogais "aeiou" apareceram {vogais} vezes na frase!!')
print(frase.replace('a','').replace('e','').replace('i','').replace('o','').replace('u',''))

"""
"""
frase = input("Digite uma frase qualquer: ") 
fraseMin = frase.lower() 
vogais = "aeiou" 
contador = 0 
"""

"""
for i in fraseMin:     
    if i in vogais:         
        contador += 1 
        print(f"A frase -> '{fraseMin}': possui {contador} vogais") 
        fraseMin = fraseMin.replace("a", "") fraseMin = fraseMin.replace("e", "") 
        fraseMin = fraseMin.replace("i", "") fraseMin = fraseMin.replace("o", "") fraseMin = fraseMin.replace("u", "") 
    print(f"A frase sem as vogais ficari assim ->", fraseMin)
"""
"""
dia = 30
mes = 12
ano = 2000

def validar(dia,mes,ano):
    if mes==1 or mes==3 or mes==5 or mes==7 or mes==8 or mes==10 or mes==12:
        if(dia<=31):
            valida=True
    elif( mes==4 or mes==6 or mes==9 or mes==11):
        if(dia<=30):
            valida = True
    elif mes==2:
        if (ano%4==0 and ano%100!=0) or (ano%400==0):
            if(dia<=29):
                valida = True
        elif(dia<=28):
                valida = True
    if(valida):
        print('Data válida')
    else:
        print('Inválida')

validar(dia,mes,ano)
"""
"""
from datetime import datetime
trabalhador = dict()

print()
trabalhador["Nome"] = str(input("Nome: "))
nascimento = int(input("Ano de nascimento: ")) 
trabalhador["Idade"] = datetime.now().year - nascimento 
trabalhador["CTPS"] = int(input("CTPS (digite 0 caso não tenha): ")) 
if trabalhador["CTPS"] != 0:
    trabalhador["Inicio no trabalhado"] = int(input("Ano de Inicio no trabalho: ")) 
    trabalhador["salario"] = float(input("Digite o Salário: R$ "))
    trabalhador["aposentadoria"] = trabalhador["Inicio no trabalho"] + 35

for chaves, valores in trabalhador.items():
    print(f"          {chaves}  {valores} ")
"""

"""
import math

class bombaCombustível:
    def init(self,tipoCombustivel,valorLitro,quantidadeCombustivel):
       self.tipoCombustivel=tipoCombustivel
       self.valorLitro=valorLitro
       self.quantidadeCombustivel=quantidadeCombustivel

    def abastecerPorLitro(self,litros):
        self.valorTotal=litros*self.valorLitro
        print(f"O valor a pagar é {self.valorTotal}")

    def abastecerPorValor(self,valor):
        self.quantidadeCombustivel=valor/self.valorLitro
        print(f"Você abasteceu {self.quantidadeCombustivel} litros")

    def alteraValor(self,novoValor):
        self.valorLitro=novoValor
        print(f"O novo valor do litro de {self.tipoCombustivel} é R${self.valorLitro}")

    def alteraTipoCombustivel(self,novoTipo):
        self.tipoCombustivel=novoTipo
        print(f"O combustivel foi alterado para {self.tipoCombustivel}")

    def alterarQuantidadeCombustivel(self,novaQuantidade):
        self.quantidadeCombustivel=novaQuantidade
        print(f"Será abastecido {self.quantidadeCombustivel} litros de {self.tipoCombustivel}")

"""
"""
class BombaCombustivel:
    def __init__(self,tipo_combustivel,valor_litro,quantidade):
        self.tipo_combustivel = tipo_combustivel
        self.valor_litro = valor_litro
        self.quantidade = quantidade

    def abastecerPorValor (self,valor):
        temp = valor/self.valor_litro  #armazena total de litros
        self.alterarQuantidadeCombustivel(self.quantidade - temp)
        return temp

    def abastecerPorLitro (self,qtd):
        temp = qtd*self.valor_litro  ##armazena valor total a ser pago
        self.alterarQuantidadeCombustivel(self.quantidade-qtd)
        return temp

    def alterarValor (self,valor):
        self.valor_litro= valor

    def alterarCombustivel(self,combustivel):
        self.tipo_combustivel= combustivel

    def alterarQuantidadeCombustivel(self,quantidade):
        self.quantidade = quantidade

gasolina = BombaCombustivel('aditivada', 6.15, 500)
print(vars(gasolina))
"""


"""
        elif(opcao == "6"):
            if(personagem.dinheiro >= 20):
                cronometro = randint(5, 10)
                Dispensa.remedios += 10
                personagem.dinheiro -= 20
                relogio.avancaTempo(cronometro)
            else:
                print("A cartela com 10 remédios custa 20 reais, você não tem dinheiro suficiente.")
                relogio.avancaTempo(cronometro)
"""

"""
            elif(personagem.sujo):
                print("Como você estava sujo, seus colegas reclamaram para seu chefe, e você levou uma advertência.")
                recebido *= 0.9
"""
"""
return (self.horas > 8 or (self.horas == 8 and self.minutos > 0))
"""

from random import randint
cronometro = randint(10, 15)



print(cronometro)