from flask import Flask, render
from flask.templating import render_template

app = Flask(__name__)

@app.route("/")
def index():
    pokemons = [
        {

        }
    ]

    caminho_base = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/"

    return render_template()