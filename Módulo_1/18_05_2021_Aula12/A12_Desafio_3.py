'''
Crie um programa que leia nome, ano de nascimento e carteira de trabalho e cadastreos 
(com idade) em um dicionário. Se por acaso a CTPS for diferente de 0, o dicionário
receberá também o ano de contratação e o salário. Calcule e acrescente , além da idade
, com quantos anos a pessoa vai se aposentar. Considere que o trabalhador deve
contribuir por 35 anos para se aposentar.
'''
from datetime import datetime # Importa a biblioteca para trabalhar com datas.

trabalhador = dict() # Dicionário vazio para armazenar o cadastro.

print()
trabalhador["Nome do Trabalh."] = str(input("Nome: ")) # input para coletar o nome do trabalhador.
nascimento = int(input("Ano de nascimento: ")) # input para coletar a data de nascimento.

# Subtrair o ano atual pelo ano de nascimento para obter a idade já acrescentando no dicionário.
trabalhador["Idade do trabal."] = nascimento - datetime.now().year 

# Coletar número carteira de trabalho.
trabalhador["CTPS trabalhado."] = int(input("CTPS (digite 0 caso não tenha): ")) 
if trabalhador["CTPS trabalhado."] != 0:
    # Coletar inicio no trabalho.
    trabalhador["Inicio no traba."] = int(input("Ano de Inicio no trabalho: ")) 
    # Coletar salário.
    trabalhador["salario do trab."] = float(input("Digite o Salário: R$ "))
    # operação para obter a idade que o trabalhador irá se aposentar.
    trabalhador["aposentadoria t."] = trabalhador["Idade do trabal."] + ((trabalhador["Inicio no traba."] - datetime.now().year + 35))
print()
print()
for chaves, valores in trabalhador.items():
    print(f"          {chaves} = {valores} ")

print()
print()