from flask import Blueprint, render_template

bp = Blueprint("bp",__name__)

@bp.route("/")
def home():
    return "Hello, Flask!!!"

@bp.route("/agenda/")
def agenda():
    return render_template("index.html")

# if (__name__ == "__main__"):
#     app.run(debug = True)