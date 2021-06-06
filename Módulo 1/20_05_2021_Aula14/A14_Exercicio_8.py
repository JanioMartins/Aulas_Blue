"""
#08 - Crie um programa que leia nome, ano de nascimento e carteira de trabalho e 
# cadastre-os (com idade) em um dicionário. Se por acaso a CTPS for diferente de 0, 
# o dicionário receberá também o ano de contratação e o salário. Calcule e acrescente , 
# além da idade, com quantos anos a pessoa vai se aposentar. 
# Considere que o trabalhador deve contribuir por 35 anos para se aposentar.
"""

print()
print( "=--=" * 25)
print()

from datetime import datetime # Importa a biblioteca para trabalhar com datas.

trabalhador = dict() # Dicionário vazio para armazenar o cadastro.

print()
trabalhador["Nome do Trabalhador.........."] = str(input("Nome: ")) # input para coletar o nome do trabalhador.
nascimento = int(input("Ano de nascimento: ")) # input para coletar a data de nascimento.

# Subtrair o ano atual pelo ano de nascimento para obter a idade já acrescentando no dicionário.
trabalhador["Idade do trabalhador........."] = datetime.now().year - nascimento 

# Coletar número carteira de trabalho.
trabalhador["CTPS do trabalhador.........."] = int(input("CTPS (digite 0 caso não tenha): ")) 
if trabalhador["CTPS do trabalhador.........."] != 0:
    # Coletar inicio no trabalho.
    trabalhador["Inicio no trabalhado........."] = int(input("Ano de Inicio no trabalho: ")) 
    # Coletar salário.
    trabalhador["salario do trabalhador......."] = float(input("Digite o Salário: R$ "))
    # operação para obter a idade que o trabalhador irá se aposentar.
    trabalhador["aposentadoria trabalhador...."] = trabalhador["Inicio no trabalhado........."] + 35
print()
print( "=--=" * 25)
print()

for chaves, valores in trabalhador.items():
    print(f"          {chaves}  {valores} ")

print()
print( "=--=" * 25)
print()
 