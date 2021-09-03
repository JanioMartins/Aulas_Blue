from flask import Flask

app = Flask(__name__)

@app.route("/doido/")
def index():
    return "../doido.html"

@app.route("/serio/")
def index():
    return "../serio.html"

if (__name__ == "__main__"):
    app.run(debug = True)