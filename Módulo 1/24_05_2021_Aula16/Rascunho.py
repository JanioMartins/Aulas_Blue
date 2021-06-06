
"""
class Herói():
    def __init__(self, nome, idade, peso):
        self.nome = nome
        self.idade = idade
        self.peso = peso

    def engordar(self, peso):
        self.peso += peso

a = Herói('Capitão América',30, 85)
print(vars(a))
a.engordar(10)
#print(vars(a))


class Pessoa():
    def __init__(self, nome, altura, peso):
        self.nome = nome
        self.altura = altura
        self.peso = peso

    def emagrecer(self, peso):
        self.peso -= peso

a = Pessoa('Steve Rogers',1.80, 90)
print(vars(a))
a.emagrecer(10)
#print(vars(a))
"""

class Conta:
    def init(self,titular,saldo):
        self.titular=titular
        self.saldo=saldo
        print(f'{self.titular} o saldo da sua conta é R${self.saldo}')

    def deposita(self):
        self.valor=0
        self.valor=(float(input(f"{self.titular} quanto quer depositar?")))
        self.saldo+=self.valor
        print(f'O seu saldo é R${self.saldo}')

    def saca(self):
        self.valor=0
        self.valor=(float(input(f"{self.titular} quanto quer sacar?")))
        self.saldo-=self.valor
        print(f'O seu saldo é R${self.saldo}')

    def transfere(self):
        self.conta_destino=input(f"{self.titular} para quem deseja transferir?")
        self.valor=float(input(f"Quanto deseja transferir para {self.conta_destino}?"))
        self.saldo-=self.valor
        print("Transferência realizada com sucesso!!")
        print(f'O seu saldo é R${self.saldo}')


a = Conta("janio", 1000.00)
a.deposita(1.000)