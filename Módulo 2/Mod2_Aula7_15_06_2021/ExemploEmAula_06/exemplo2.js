function altera(){
    const elemento1 = document.getElementById('botao')
    if (elemento1.innerText == "Texto mudou") {
        elemento1.innerText = "Texto voltou";
        this.document.bgColor = "black";
    } 
    else {
        elemento1.innerText = "Texto mudou";
        this.document.bgColor = "red";
    }
}