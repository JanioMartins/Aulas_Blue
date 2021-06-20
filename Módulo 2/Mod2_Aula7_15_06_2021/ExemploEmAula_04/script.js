function altera(){
    const elemento1 = this.document.getElementById('botao');
    const elementos2 = this.document.getElementsByClassName('classe1');
    const elemento3 = this.document.getElementById('div-diferente')
    if (elemento1.innerText == "Texto mudou") {
        for (const elemento of elementos2){
            elemento.innerHTML = 'mudando <b>innerHTML</b>'
        }
        elementos2[1].innerHTML = '<h1>este é diferente</h1>'
        //elemento3.innerHTML = '<h1>este é diferente</h1>'
        elemento1.innerText = "Texto voltou";
elemento1.style.background = "#000000";
        elemento1.style.color = "#ffffff";
        this.document.bgColor = "#f2f1d0"; // this REFERE-SE A """ESTA""" JANELA (Window)
    } 
    else {
        for (const elemento of elementos2){
            elemento.innerHTML = 'mudando <b>innerHTML</b> de volta'
        }
        elementos2[1].innerHTML = '<h1>este ainda é diferente</h1>'
        //elemento3.innerHTML = '<h1>este ainda é diferente</h1>'
        elemento1.innerText = "Texto mudou";
        elemento1.style.background = "#ffffff";
        elemento1.style.color = "#000000";
        this.document.bgColor = "#f2d0d0";
    }
}
