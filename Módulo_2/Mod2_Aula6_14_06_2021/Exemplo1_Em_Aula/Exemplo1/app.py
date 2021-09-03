from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/", methods=('GET', 'POST'))
def index():
    nome = None
    sobrenome = None
    criatura = None
    imagem = None

    if request.method == 'POST':
        nome = request.form['nome']
        sobrenome = request.form['sobrenome']
        criatura = request.form['criatura']

        if criatura == "elfo":
            imagem = "https://i.pinimg.com/originals/52/b8/c3/52b8c320e93e722020f51d6e4920d6bc.gif" # imagem de elfo
        elif criatura == "orc":
            imagem = "https://thumbs.gfycat.com/ExemplarySeriousBeardedcollie-max-1mb.gif" # imagem do orc
        elif criatura == "hobbit":
            imagem = "https://media.tenor.com/images/a758b5c5a136dde219fc5926b42c7b1b/tenor.gif" # imagem do hobbit
        else:
            imagem = None

    return render_template("index.html", nome=nome, sobrenome=sobrenome, criatura=criatura, imagem=imagem)

if (__name__ == "__main__"):
    app.run(debug=True)