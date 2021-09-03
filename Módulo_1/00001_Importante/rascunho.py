

nascimento = input("Digite sua data de nascimento (DD/MM/AAAA): ")
dia, mesDat, ano = nascimento[:2], nascimento[3:5], nascimento[6:10]
res = dia + mesDat + ano
m = int(res[2:4])

mesesExt = ("Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Julho", "Julho", 
"Agosto", "Setembro", "Outubro", "Novembro", "Dezembro")

print(dia, "de", mesesExt[m - 1] ,"de", ano)
print(dia, "de", m - 1,"de", ano)