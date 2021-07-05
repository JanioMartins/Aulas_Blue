from flask import Flask, render_template, request
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

# Configurações de acesso ao banco de dados
user = 'rupyzmta'
password = 'fbTlMcKTPhG-7DKqKp8hcmuPJvXu1iah'
host = 'tuffi.db.elephantsql.com'
database = 'rupyzmta'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "uma chave secreta bem secreta"

# Instanciando objeto da classe SQLAlchemy
db = SQLAlchemy(app)

# Modelar a Classe Filmes -> tabela filmes
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
        # SELECT * FROM filmes WHERE id = X, on X é o valor do id na coluna id da tabela filmes
        return Filmes.query.get(id_registro)
    
    @staticmethod
    def conta():
        # SELECT COUNT (*) FROM filmes
        return Filmes.query.count()
    
    def save(self): # função que salva as novas informações no banco de dados
        db.session.add(self) # adiciona o novo registro através da session ao DB
        db.session.commit() # realiza o commit da session do DB

    def update(self, novo_nome, nova_imagem_url): # função que atualiza os valores de nome e imagem_url
        self.nome = novo_nome # atribui novo nome ao registro
        self.imagem_url = nova_imagem_url # atribui nova imagem_url ao registro

        self.save() # chama a função save para salvar as alterações

    def delete(self): # função que apaga informações no banco de dados
        db.session.delete(self) # apaga o registro através da session ao DB
        db.session.commit() # realiza o commit da session do DB


@app.route("/")
def index():
    total = Filmes.conta()
    return render_template("index.html", total=total)


@app.route("/read")
def read_all():
    # Chamada do método read_all da classe Filmes, que representa a tabela filmes do banco de dados.
    registros = Filmes.read_all()
    return render_template("read_all.html", registros=registros)


@app.route("/read/<id_registro>")
def read_id(id_registro):
    # Chamada do método read_single da classe Filmes
    registro = Filmes.read_single(id_registro)
    return render_template("read_single.html", registro=registro)


@app.route("/create", methods=('GET', 'POST'))
def create():
    novo_id = None # cria uma variável nula para o novo ID atribuído

    if request.method == 'POST': # verifica se está recebendo alguma coisa por POST
        form = request.form # armazena o formulário recebido por POST
        
        registro = Filmes(form['nome'], form['imagem_url']) # cria um novo registro (objeto) com nome e imagem_url recebidos
        registro.save() # chama a função save da classe (adiciona e commita)

        novo_id = registro.id # atribui a novo_id o ID do novo registro criado

    return render_template("create.html", novo_id=novo_id) # carrega o create.html passando o valor de novo_id (None ou novo ID atribuído)




@app.route('/update/<id_registro>', methods=('GET', 'POST'))
def update(id_registro):
    sucesso = False # definir se houve sucesso na alteração ou não

    registro = Filmes.read_single(id_registro) # recuperando o registro com ID igual a id_registro

    if request.method == 'POST':
        form = request.form # recupera o form enviado
        
        # novo_registro = Filmes(form['nome'], form['imagem_url'])
        # registro.update(novo_registro)

        registro.update(form['nome'], form['imagem_url']) 
        # chama a função update do objeto "registro", que é da classe Filmes, com os novos valores de nome e imagem_url!

        sucesso = True
    
    return render_template('update.html', registro=registro, sucesso=sucesso)



@app.route('/delete/<id_registro>')
def delete(id_registro):
    registro = Filmes.read_single(id_registro) # recupera o registro com id passado na rota
    return render_template("delete.html", registro=registro) # carrega a página de confirmação

@app.route('/delete/<id_registro>/confirmed')
def delete_confirmed(id_registro):
    sucesso = False 

    registro = Filmes.read_single(id_registro) # recupera o registro com id passado na rota

    if registro:
        registro.delete() # chama a função delete para apagar o registro
        sucesso = True # muda o valor da variável sucesso

    return render_template("delete.html", registro=registro, sucesso=sucesso)


if (__name__ == "__main__"):
    app.run(debug=True)