'''
1. Crie um programa onde você cadastre a data de nascimento (dd/mm/aa) de algumas
celebridades em um dicionário. Ao escolher uma celebridade, seu programa deve
retornar a data completa. Não esqueça de validar se a celebridade escolhida está
presente em seu dicionário.
'''

'''
celebridades = {"Albert Einsten" : "21/09/1857",, "Benjamin Franklin" : "02/11/1809", "Chuck Noris" : "30/10/1971", 
"Donald Trump" : "25/01/1977", "Bruce Lee" : "29/04/1967", "Rowan Atkinson" :"01/01/1900"}
'''
celebridades = {"Albert Einsten" : 1857, "Benjamin Franklin" : 1809, "Chuck Noris" : 1971, 
"Donald Trump" : 1977, "Bruce Lee" : 1967, "Rowan Atkinson" : 1900}

print()
print("Lista de cadastro")
print()
for i in celebridades:
    print(i)

busca = input("Escolha a celebridade: ").title()
print(celebridades[busca])
print(f"{busca} teria", 2021 - int(celebridades[busca]), "anos de idade")
