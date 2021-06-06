'''
2. Crie um programa que gerencie o aproveitamento de um jogador de futebol. O
programa vai ler o nome do jogador e quantas partidas ele jogou. Depois vai ler a
quantidade de gols feito em cada partida. No final tudo isso será guardado em um
dicionário, incluindo o total de gols feitos durante o campeonato.
'''
dic = {}

nome = input("Digite o nome do jogador: ")
q_partidas = int(input("Digite a quantidade de partidas: "))


gols_partida = []
for partida in range(1, q_partidas + 1):
    gols_partida.append(int(input(f"Quantidade de gols na partida {partida}: ")))
    
    total_gols = sum(gols_partida)

dic[1] = nome
print(dic)