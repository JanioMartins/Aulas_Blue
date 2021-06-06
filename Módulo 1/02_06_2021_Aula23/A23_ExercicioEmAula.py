
from random import randint

class Lançador:
    def __init__(self):
        self.dado = 1
        self.moeda = "cara"

    def lanca_dado(self):
        self.dado = randint(1, 6)
        print(f"Você rolou o número: {self.dado}")

    def lanca_moeda(self):
        self.moeda = randint(1, 2)
        if self.moeda == 1:
            print(f"Você tirou Cara")
        else:
            print(f"Você tirou Caroa")


jogar = Lançador()
jogar.lanca_dado()
jogar.lanca_moeda()
