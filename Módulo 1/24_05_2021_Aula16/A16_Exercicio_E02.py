

class conta():
    def __init__(self, titular, saldo):
        self.titular = titular
        self.saldo = saldo

    def saque(self, saldo):
        self.saldo -= saldo
        print(f"Saldo após o saque: {self.saldo}")

    def deposito(self, saldo):
        self.saldo += saldo
        print(f"Saldo após o saque: {self.saldo}")


a = conta( "Janio Martins", 30)
print(vars(a))
a.saque(10)
