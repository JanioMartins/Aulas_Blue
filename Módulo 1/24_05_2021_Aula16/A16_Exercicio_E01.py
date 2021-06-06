

class pessoa():
    def __init__(self, nome, sobrenome, idade):
        self.nome = nome
        self.sobrenome = sobrenome
        self.idade = idade

    def dados(self):
        print(f"A pessoa {self.nome} {self.sobrenome} tem {self.idade} anos de idade.")


a = pessoa("Janio", "Martins", 30)

print(vars(a))
a.dados()