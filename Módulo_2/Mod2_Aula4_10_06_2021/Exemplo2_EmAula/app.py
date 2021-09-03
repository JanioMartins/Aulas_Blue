from flask import Flask, render_template
app = Flask(__name__)

@app.route("/")
def aluno():
    nome = "Janio"

    idade = 32
    if idade >= 18:
        maioridade = True
    else:
        maioridade = False

    cidade = "São Paulo"
    imagem1 =  "/static/logo-blue-croped.gif"
    imagem2 = "/static/BlueEdtech2.jpg"
    return render_template("index.html", nome = nome, idade = idade, cidade = cidade, imagem1 = imagem1, imagem2 = imagem2, maioridade = maioridade)

if __name__ == "__main__":
    app.run(debug = True)