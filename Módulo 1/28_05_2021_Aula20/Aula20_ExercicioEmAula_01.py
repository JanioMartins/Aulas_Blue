

class Pessoa:
    def __init__ (self, nome, idade, cpf, telefone):
        self.__nome = nome
        self.__idade = idade
        self.__cpf = cpf
        self.__telefone = telefone


    def getNome (self):
        return self.__nome

    def getIdade (self):
        return self.__idade

    def getCpf (self):
        return self.__cpf
    
    def getTelefone (self):
        return self.__telefone


    def setNome (self, nome):
        self.__nome = nome

    def setIdade (self, idade):
        self.__idade = idade

    def setCpf (self, cpf):
        self.__cpf = cpf
    
    def setTelefone (self, telefone):
        self.__telefone = telefone

class Advogado(Pessoa):
    def __init__(self, nome, idade, cpf, telefone, oab):
        self.__oab = oab
        super().__init__(nome, idade, cpf, telefone)


class Medico(Pessoa):
    def __init__(self, nome, idade, cpf, telefone, crm):
        self.__crm = crm
        super().__init__(nome, idade, cpf, telefone)


profissional = Pessoa("Janio", 34, "333.333.333-33", "11 9.9999-9999")
profissional.getNome()
print(vars(profissional))
lista = []
lista.append(profissional.getNome())
lista.append(profissional.getIdade())
lista.append(profissional.getCpf())
lista.append(profissional.getTelefone())
print()
print(lista)
print()
print(profissional.setNome())
profissional.setNome("Martins")
print(profissional.setNome())
print()
print(profissional.setIdade())
profissional.setIdade(43)
print(profissional.setIdade())
print()
print(profissional.setCpf())
profissional.setCpf("555.555,555-55")
print(profissional.setCpf())
print()
print(profissional.setTelefone())
profissional.setTelefone("15 98888-8888")
print(profissional.setTelefone())
print()
