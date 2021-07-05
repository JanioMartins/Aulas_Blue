from flask import Flask, render_template, request
from flask_sqlalchemy import SQLAlchemy


app = Flask(__name__)

# Configurações de acesso ao banco de dados (Elephant com Postgre SQL)
user = 'rupyzmta'
password = 'fbTlMcKTPhG-7DKqKp8hcmuPJvXu1iah'
host = 'tuffi.db.elephantsql.com'
database = 'rupyzmta'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}' 
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "uma chave secreta bem secreta"

# Instanciando objeto da classe SQLAlchemy (Indicando que será trabalhado com banco de dados)
db = SQLAlchemy(app)

# Modelar a Classe Filmes -> tabela filmes (Tabela de filmes em Postgre SQL)
class Filmes(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    nome = db.Column(db.String(255), nullable=False)
    imagem_url = db.Column(db.String(255), nullable=False)

    def __init__(self, nome, imagem_url):
        self.nome = nome
        self.imagem_url = imagem_url
    
    @staticmethod
    def read_all():
        # SELECT * FROM filmes ORDER BY id ASC
        return Filmes.query.order_by(Filmes.id.asc()).all()

    @staticmethod
    def read_single(id_registro):
        # SELECT * FROM filmes WHERE id = X, onde o X é o valor do id na coluna id da tabela filmes
        return Filmes.query.get(id_registro)

    def save(self): # função que salva as novas informações no banco de dados
        db.session.add(self) # adiciona o novo registro através da session ao DB
        db.session.commit() # realiza o commit da session do DB



@app.route("/")
def index():
    return render_template("index.html")


@app.route("/read")
def read_all():
    # Chamada do método read_all da classe Filmes, que representa a tabela filmes do banco de dados.
    registros = Filmes.read_all()
    return render_template("read_all.html", registros=registros)


@app.route("/read/<id_registro>")
def read_id(id_registro):
    # Chamada do método read_single da classe Filmes (Retorna as informações relacionas ao filme escolhido)
    registro = Filmes.read_single(id_registro)
    return render_template("read_single.html", registro=registro)

@app.route("/create", methods=('GET', 'POST'))
def create():
    novo_id = None # cria uma variável nula para o novo ID atribuído

    #Condição para inclusão de registros feitos pelo usuário final.
    if request.method == 'POST': # verifica se está recebendo alguma coisa por POST (do formulário na página create)
        form = request.form # armazena o formulário recebido por POST

        registro = Filmes(form['nome'], form['imagem_url']) # cria um novo registro (objeto) com nome e imagem_url recebidos
        registro.save() # chama a função save da classe (adiciona e commita)

        novo_id = registro.id # atribui a novo_id o ID do novo registro criado

    return render_template("create.html", novo_id=novo_id) # carrega o create.html passando o valor de novo_id (None ou novo ID atribuído)

@app.route("/read_buscar", methods=('GET', 'POST'))
def read_buscar():

    return render_template("read_buscar.html")

if (__name__ == "__main__"):
    app.run(debug=True)