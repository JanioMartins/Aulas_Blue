from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def index():
    return render_template("index.html")

registros = [
    {
        "id": 1,
        "nome": "A Procura da Felicidade",
        "imagem_url":"https://coisasdetv.com/wp-content/uploads/critica-de-hector-e-o-segredo-da-felicidade-um-pouco-branda.jpg"
    },
    {
        "id": 2,
        "nome": "Laranja Mecânica",
        "imagem_url":"https://br.web.img2.acsta.net/c_310_420/medias/nmedia/18/91/05/58/20127559.jpg"
    },
    {
        "id": 3,
        "nome": "Frozen",
        "imagem_url":"https://lumiere-a.akamaihd.net/v1/images/p_frozen_18373_3131259c.jpeg"
    },
]



@app.route("/read")
def read_all():
    return render_template("read_all.html", registros=registros)

@app.route("/read/<id_registro>")
def read_id():
    return "Em construção - Visualizar registro de ID "+id_registro

@app.route("/create")
def create():
    return "Em construção - Ainda será feito o CREATE!"

if (__name__ == "__main__"):
    app.run(debug=True)