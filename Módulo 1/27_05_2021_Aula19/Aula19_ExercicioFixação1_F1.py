"""
a. Crie uma classe chamada bombaCombustível, com no mínimo esses atributos:
i. tipoCombustivel.
ii. valorLitro.
iii. quantidadeCombustivel.
b. A classe deve possuir no mínimo esses métodos:
i. abastecerPorValor( ) – método onde é informado o valor a ser abastecido e mostra a quantidade de litros que
foi colocada no veículo.
ii. abastecerPorLitro( ) – método onde é informado a quantidade em litros de combustível e mostra o valor
a ser pago pelo cliente.
iii. alterarValor( ) – altera o valor do litro do combustível.
iv. alterarCombustivel( ) – altera o tipo do combustível.
v. alterarQuantidadeCombustivel( ) – altera a quantidade de combustível restante na bomba.
OBS: Sempre que acontecer um abastecimento é necessário atualizar a quantidade de combustível total na bomba.
"""

class bombaCombustivel:
    def __init__(self, tipoCombustivel, valorLitro, quantidadeCombustivel):
        self.tipoCombustivel = tipoCombustivel
        self.valorLitro = valorLitro
        self.quantidadeCombustivel = quantidadeCombustivel

    def abastecerPorValor(self, valor):
        temp = valor / self.valorLitro
        self.alterarQuantidadeCombustivel(self.quantidadeCombustivel -  temp)
        return temp

    def abastescerPorLitro(self, qtd):
        temp = qtd * self.valorLitro
        self.alterarQuantidadeCombustivel(self.quantidadeCombustivel -  qtd)
        return temp

    def alterarValor(self, valor):
        self.valorLitro = valor

    def alterarCombustivel(self, combustivel):
        self.tipoCombustivel = combustivel

    def alterarQuantidadeCombustivel(self, quantidade):
        self.QuantidadeCombustivel = quantidade

   


gasolina = bombaCombustivel("Gasolina", 5.35, 15)
print(vars(gasolina))
gasolina.alterarValor(6.11)
print(vars(gasolina))
gasolina.alterarCombustivel("Gasolina Supra")
print(vars(gasolina))
gasolina.alterarQuantidadeCombustivel(1000)
print(vars(gasolina))

# abastecer por litros
litros = 50
print(f"O valor a ser pago para abastecer {litros} L é R$ {gasolina.abastescerPorLitro(litros):.2f}")
print(vars(gasolina))

# abastecer por valor
valor = 50
print(f"O total de litros abastecidos com R$ {valor:.2f} é {gasolina.abastecerPorValor(valor):.2f} L")
print(vars(gasolina)) 