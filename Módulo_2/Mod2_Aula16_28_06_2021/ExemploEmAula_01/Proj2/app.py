from flask import Flask, render_template
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

user = 'rupyzmta'
password = 'fbTlMcKTPhG-7DKqKp8hcmuPJvXu1iah'
host = 'tuffi.db.elephantsql.com'
database = 'rupyzmta'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}' 
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "uma chave secreta bem secreta"

db = SQLAlchemy(app)

#MODELAR CLASSE FILMES -> TABELA FILMES
class Filmes(db.Model):
	id = db.Column(db.Integer, primary_key=True)
	nome = db.Column(db.String(255), nullable=False)
	imagem_url = db.Column(db.String(255), nullable=False)

	def __init__(self, nome, imagem_url):
		self.nome = nome
		self.imagem_url = imagem_url

	@staticmethod
	def read_all():	
		return Filmes.query.order_by(Filmes.id.asc()).all()


@app.route("/")
def index():
    return render_template("index.html")

@app.route("/read")
def catalogo():
	registros = Filmes.read_all()
	return render_template("read_all.html", registros = registros)

@app.route("/read/<id_registro>")
def read_id():
    return "Em construção - Visualizar registro de ID "

@app.route("/create")
def create():
    return "Em construção - Ainda será feito o CREATE!"

if (__name__ == "__main__"):
    app.run(debug=True)
	
	