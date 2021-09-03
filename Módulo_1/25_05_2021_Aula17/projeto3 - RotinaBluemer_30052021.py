# Proposta de projeto de ficção interativa para avaliação de OO
# Sugestão: completar com classes filhas colocando pessoas saudáveis, 
# trabalhos menos remunerados, casas melhor equipadas et cetera



from random import randint


# Classe para a criação do objeto tipo relógio para iteração de tempo no programa;
class Relogio:
    def __init__(self): # Construtor padrão com dois atributos assumidos;
        self.horas = 7
        self.minutos = 0
    
    def __str__(self): # Método para retornar mensagem;
        return f"{self.horas:02d}:{self.minutos:02d}"
    
    def avancaTempo(self, minutos):  # Método para validar minutos em horas e alterar os contadores de minutos e de horas;
        self.minutos += minutos
        while(self.minutos >= 60):
            self.minutos -= 60
            self.horas += 1
    
    def atrasado(self): # Método para definir o ponto (tempo) para o inicio do atraso;
        return (self.horas > 8 or (self.horas == 8 and self.minutos > 0))

# Teste de alterações;
tempo = Relogio()
tempo.avancaTempo(60)
tempo.atrasado()
print(vars(tempo))


# Classe para a criação do personagem;
class Personagem:
    def __init__(self, nome):
        self.nome = nome
        self.nivel = "junior"
        self.sujo = True
        self.fome = True
        self.cafe = False
        valcher = randint(100.00, 121.00)
        self.dinheiro = 0 + int(valcher)
        self.salario = 100

    
    def __str__(self):
        return f"Olá {self.nome} Você é um Programador {self.nivel} e acaba de ingressar á equipe Blue Edtech.\n- Você está "+" "+("com" if self.fome else "sem")+" fome e "+("" if self.cafe else "não ")+"há ingredientes para o preparo do café na sua dispensa.\n- Você tem "+str(self.dinheiro)+" reais na sua conta."

    def dormir(self):
        self.sujo = True
        self.fome = True
        self.medicado = False

# Teste de alterações;
programador = Personagem("Janio")
programador.dormir()
print(vars(programador))

# Classe para armazenar quantidade de alimentos na dispensa da casa;
class Dispensa:
    def __init__(self):
        self.remedios = 1
        self.cafe = 1
        self.almoco = 1
        self.jantar = 1

# Teste de alterações;
refeicoes = Dispensa()
print(vars(refeicoes))

if(__name__ == "__main__"):
    dia = 1
    relogio = Relogio()
    personagem = Personagem("Janio")
    dispensa = Dispensa()
    remedios = False
    cafe = False
    almoco = False
    jantar = False
    

    while True:
        print("=-="*20)
        print("São "+str(relogio)+" do dia "+str(dia)+". Você tem que iniciar o trabalho até às 08:00.")
        print(personagem)
        print("=-="*20)
        print("Ações:")
        print("1 - Tomar banho e escovar os dentes")
        print("2 - Fazer café da manhã")
        print("3 - Pedir café da manhã")
        print("4 - Tomar café da manhã")
        print("5 - Fazer Alongamento")
        print("6 - Iniciar o trabalho")
        print("0 - Sair do jogo")
        opcao = input("Escolha sua ação:")

        if(opcao == "1"):
            cronometro = randint(5, 16)
            personagem.sujo = False
            relogio.avancaTempo(cronometro)

        elif(opcao == "2"):
            cronometro = randint(5, 16)
            if(Dispensa.cafe > 0):
                Dispensa.cafe -= 1
                cafe = True
            else:
                print("Não há cafe em casa.")
            relogio.avancaTempo(cronometro)

"""
        elif(opcao == "3"):
            if(personagem.dinheiro >= 15):
                personagem.dinheiro -= 15
                cafe_da_manha = True
            else:
                print("O café da manhã custa 15 reais, você não tem dinheiro suficiente.")
            relogio.avancaTempo(5)
        elif(opcao == "4"):
            if(cafe_da_manha):
                personagem.fome = False
                cafe_da_manha = False
                relogio.avancaTempo(15)
            else:
                print("Não tem café da manhã na sua casa.")
                relogio.avancaTempo(5)
        elif(opcao == "5"):
            if(casa.remedios > 0):
                casa.remedios -= 1
                personagem.medicado = True
            else:
                print("Não tem remédio na sua casa")
            relogio.avancaTempo(5)
        elif(opcao == "6"):
            if(personagem.dinheiro >= 20):
                casa.remedios += 10
                personagem.dinheiro -= 20
                relogio.avancaTempo(10)
            else:
                print("A cartela com 10 remédios custa 20 reais, você não tem dinheiro suficiente.")
                relogio.avancaTempo(5)
        elif(opcao == "7"):
            print("-=-=-")
            print("Você foi trabalhar.")
            print(personagem)
            print("-=-=-")
            recebido = personagem.salario
            if(not personagem.medicado):
                print("Como você não tomou seu remédio, você ficou doente no caminho e não chegou no trabalho")
                recebido = 0
            elif(personagem.sujo):
                print("Como você estava sujo, seus colegas reclamaram para seu chefe, e você levou uma advertência.")
                recebido *= 0.9
            elif(personagem.fome):
                print("Como você estava com fome, você trabalhou metade do que consegue trabalhar.")
                recebido *= 0.5
            elif(relogio.atrasado()):
                print("Como você chegou atrasado, você produziu menos do que de costume.")
                recebido *= 0.8
            print("Você recebeu "+str(recebido)+" reais pelo seu trabalho hoje.")
            print("-=-=-")

            personagem.dinheiro += recebido
            personagem.dormir()
            relogio = Relogio()
            dia+=1
        elif(opcao == "0"):
            break
        else:
            print("Opção inválida!")
            relogio.avancaTempo(5)
"""