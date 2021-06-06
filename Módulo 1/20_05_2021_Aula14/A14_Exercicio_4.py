"""
#04 - Utilizando funções e listas faça um programa que receba uma data 
# no formato DD/MM/AAAA e devolva uma string no formato D de mesPorExtenso de AAAA. 
# Valide a data e retorne NULL caso a data seja inválida.
"""

print()
print( "=--=" * 25)
print()

def dat_rec(d):
    dia, mesDat, ano = d[:2], d[3:5], d[6:10] #fatiamento da data digitada pelo usuário.
    res = dia + mesDat + ano
    m = int(res[2:4])

#Declaração dos meses por extenso para validar os indices e inserir na frase.
    mesesExt = ("Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", 
    "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro") 

    print(dia, "de", mesesExt[m - 1],"de", ano)



d = input("Digite a data (DD/MM/AAAA): ")

dat_rec(d)

print()
print( "=--=" * 25)
print()