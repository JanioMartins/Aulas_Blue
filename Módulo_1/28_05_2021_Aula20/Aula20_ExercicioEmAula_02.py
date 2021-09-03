
"""
Crie uma classe chamada Ingresso, que possui um valor em reais e um
método imprimirValor(). Crie uma classe IngressoVIP, que herda de Ingresso e
possui um valor adicional. Crie um método que retorne o valor do ingresso VIP
(com o adicional incluído). Crie um programa para criar as instâncias de
Ingresso e IngressoVIP, mostrando a diferença de preços
"""

class Ingresso:
    def __init__(self, valor):
        self.valor = valor

    def imprimirValor(self):
        print(f"O valor do ingresso é R$ {self.valor}")
        return f"O valor do ingresso é R$ {self.valor}"


class IngressoVIP(Ingresso):
    def __init__(self, valor, adicional):
        self.valorAdicional = adicional
        super().__str__(valor)

    def imprimirValorVIP(self):
        print(f"O valor do ingresso é R$ {self.valor + self.valorAdicional}")
        return f"O valor do ingresso é R$ {self.valor + self.valorAdicional}"
           

entrada = Ingresso(100)
entradaVip = IngressoVIP(100)
    
print(vars(entrada))
print(vars(entradaVip))
