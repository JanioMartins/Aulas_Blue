'''
Crie um programa em que 4 jogadores, joguem um dado e tenham resultados
aleatórios. Guarde esses resultados em um dicionário. No final coloque esse dicionário
em ordem, sabendo que o vencedor tirou o maior número no dado. Dicas: procure
sobre a função randint(), sleep() e itemgetter da bliblioteca operator.
'''
from random import randint
from time import sleep
from operator import itemgetter
dado = {"Jogador1": randint(1, 6), "Jogador2": randint(1, 6), 
"Jogador3": randint(1, 6), "Jogador4": randint(1, 6)}
ordem = list()
for k, v in dado.items():
    print(f"O {k} tirou o número {v} no dado.")
    sleep(1)
ordem = sorted(dado.items(), key = itemgetter(1), reverse = True)
for i, valor in enumerate(ordem):
    print(f"{i+1}° lugar com o número {valor[1]}, {valor[0]}")
    sleep(1)