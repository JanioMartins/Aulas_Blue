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
        
    
# Classe para a criação do personagem;
class Personagem:
    def __init__(self, nome):
        self.nome = nome
        self.nivel = "Júnior"
        self.sujo = True
        self.fome = True
        self.alongado = False
        self.vaucher = randint(100.00, 121.00)
        self.dinheiro = 0 + int(self.vaucher)
        self.salario = 100

    
    def __str__(self):
        return f"\n- Olá {self.nome}, Você é um Programador {self.nivel} na Blue Edtech, e trabalha em Home Office.\n- Você recebeu um Vaucher no valor de R$ {self.vaucher} reais.\n- Você está "+ ("sujo." if self.sujo else "limpo.")+"  \n- Você está "+("com" if self.fome else "sem")+" fome. \n- Você tem R$ "+str(self.dinheiro)+" reais na sua conta.\n- Você "+("" if self.alongado else "não ")+"está alongado."

    def dormir(self):
        self.sujo = True
        self.fome = True
        self.alongado = False

# Declarando argumentos;
programador = Personagem("Janio")

# Classe para armazenar quantidade de alimentos na dispensa da casa;
class Dispensa:
    def __init__(self):
        self.remedios = 0
        self.cafe = 2

# Parte principal do programa;
if(__name__ == "__main__"):
    dia = 1
    relogio = Relogio()
    personagem = Personagem("Janio")
    salario = Personagem(100)
    dispensa = Dispensa()
    fome = True
    cafe = True

    while True:
        print("=-="*30)
        print(personagem)
        print("=-="*30)
        print("São "+str(relogio)+" do dia "+str(dia)+". Você tem que iniciar o trabalho até às 08:00.")
        print("=-="*30)
        print("                       Ações:")
        print("                       1 - Tomar banho e escovar os dentes")
        print("                       2 - Fazer café da manhã")
        print("                       3 - Pedir café da manhã")
        print("                       4 - Tomar café da manhã")
        print("                       5 - Fazer Alongamento")
        print("                       6 - Fazer compras no supermercado")
        print("                       7 - Iniciar o trabalho")
        print("                       0 - Sair do jogo")
        print("=-="*30)
        opcao = input("                       Escolha sua ação: ")
        print("=-="*30)

        if(opcao == "1"):
            cronometro = randint(10, 26)
            personagem.sujo = False
            relogio.avancaTempo(cronometro)

        elif(opcao == "2"):
            cronometro = randint(10, 21)
            if dispensa.cafe > 0:
                dispensa.cafe -= 1
                cafe = True
                relogio.avancaTempo(cronometro)
            else:
                cronometro = randint(1, 6)
                print("Não há cafe em casa.")
                relogio.avancaTempo(cronometro)

        elif(opcao == "3"):
            if(personagem.dinheiro >= 15):
                cronometro = randint(10, 21)
                personagem.dinheiro -= 15
                cafe = True
            else:
                print("O café da manhã custa 15 reais, você não tem dinheiro suficiente.")
            relogio.avancaTempo(cronometro)

        elif(opcao == "4"):
            if(cafe):
                cronometro = randint(10, 21)
                personagem.fome = False
                cafe = False
                relogio.avancaTempo(cronometro)
            else:
                print("Não tem café da manhã na sua casa.")
                relogio.avancaTempo(cronometro)

        elif(opcao == "5"):
            cronometro = randint(5, 16)
            personagem.alongado = True
            alongado = True
            relogio.avancaTempo(cronometro)

        elif(opcao == "6"):
            valor_gasto = randint(80, 110)
            if(valor_gasto <= personagem.dinheiro > 0):
                cronometro = randint(20, 41)
                personagem.dinheiro -= valor_gasto
                dispensa.cafe = 6
                print(f"- Você fez compras e agora tem ingredientes para o preparo de {dispensa.cafe} cafés.")

            else:
                print(f"O valor da compra foi de {valor_gasto}, você não tem dinheiro suficiente.")
            relogio.avancaTempo(cronometro)

        elif(opcao == "7"):
            print("=-="*30)
            print("Você foi trabalhar.")
            print(personagem)
            print("=-="*30)
    
            recebido = personagem.salario          

            if(not personagem.alongado):
                print("- Como não você alongou,\n- você sentiu dores durante o trabalho, e não trabalhou meio período.\n- Houve um desconto proporcional ao período não trabalhado.")
                recebido *= 0.90

            elif (personagem.fome):
                print("Como você estava com fome, você trabalhou metade do que consegue trabalhar.")
                recebido *= 0.5  

            elif(relogio.atrasado()):
                print("- Como você chegou atrasado, você produziu menos do que de costume.")
                recebido *= 0.8

            print("- Você recebeu "+str(recebido)+" reais pelo seu trabalho hoje.")
            print("=-="*30)

            personagem.dinheiro += recebido
            personagem.dormir()
            relogio = Relogio()
            dia+=1

        elif(opcao == "0"):
            cronometro = randint(5, 10)
            break
        else:
            print("Opção inválida!")
            relogio.avancaTempo(cronometro)