const botao = document.querySelector("#botao");
const liberarBotao = document.querySelector("#liberarBotao");

function botaoFoiClicado() {
    alert("Clicou no botão.");
}

function liberarBotaoClicado() {
    // Botão
    botao.addEventListener("click", botaoFoiClicado);
    botao.innerHTML = 'Clique aqui!';
    botao.removeAttribute('disabled');

    // Liberar Botão
    liberarBotao.style.display = 'none';

    // Exibir mensagem no console informando que o evento foi adicionado.
    console.log("Evento adicionado ao botão. Clique para exibir uma mensagem.");

    // Remover evento após 3 segundos
    setTimeout(function () {
        botao.removeEventListener("click", botaoFoiClicado);

        botao.innerHTML = 'Tempo expirado :(';
        botao.setAttribute('disabled', 'disabled');

        liberarBotao.style.display = 'block';

        console.log("3 segundos se passaram, botão não possui mais o evento.");
    }, 3000);
}

liberarBotao.addEventListener("click", liberarBotaoClicado);

liberarBotaoClicado();


