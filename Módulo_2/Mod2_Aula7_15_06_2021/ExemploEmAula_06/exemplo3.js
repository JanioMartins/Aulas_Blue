//const elemento_botao = document.getElementById('botao');
const elemento_botao = document.querySelector('#botao') // USANDO QUERY SELECTOR PARA IDENTIFICAR O ELEMENTO

function botaoFoiClicado(){ // DECLARANDO UMA FUNÇÃO NO JS
    alert("O botao foi clicado!") // ABRINDO UM ALERT
    window.location.href = "http://www.google.com"; // REDIRECIONANDO A PÁGINA
}

elemento_botao.addEventListener("click", botaoFoiClicado) // ADICIONANDO UM LISTENER
console.log("Evento de clique adicionado ao botão!") // ESCREVENDO NO CONSOLE - F12
elemento_botao.innerText = "Clique aqui" // MUDANDO O TEXTO DO BOTÃO
console.log("Nome do botão alterado!") // ESCREVENDO NO CONSOLE - F12

function removeEvento(){
    elemento_botao.removeEventListener("click", botaoFoiClicado) // Removendo o evento do botão
    elemento_botao.innerText = "Nem adianta clicar" // Mudando o texto do botão
    elemento_botao.setAttribute('disabled', 'disabled') // DESABILITANDO O BOTÃO
    console.log("Evento de clique removido do botão!") // F12
}

setTimeout(removeEvento, 5000) // CRONÔMETRO DE 5s PARA REMOVER O EVENTO DO BOTÃO E 
