'''
 Faça um programa que leia nome e média de um aluno, guardando também a situação
em um dicionário. No final, mostre o conteúdo sa estrutura na tela. A média para
aprovação é 7. Se o aluno tirar entre 5 e 6.9 está de recuperação, caso contrário é
reprovado.
'''

nome=input("Digite o nome do aluno: ").title()
media=float(input("Digite a média do aluno: "))
if media>=7:
    situacao="Aprovado"
elif media<7 and media >=5:
    situacao="Recuperação"
else:
    situacao='Reprovado'
    
ficha = {"Aluno" : nome , "Média" : media , "Situação" : situacao}
print(ficha)