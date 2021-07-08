// Definir os dados iniciais
const pessoa = {
    nome: 'Betão',
    sobrenome: 'Einstein',
    idade: 42,

    doido: false,

    imagem_serio: 'https://upload.wikimedia.org/wikipedia/commons/5/50/Albert_Einstein_%28Nobel%29.png',
    imagem_doido: 'https://www.hypeness.com.br/1/2017/08/EinsteinL3.jpg'
}

// Capturar os elementos pelo Id
const elementoNome = document.querySelector("#nome");
const elementoSobrenome = document.querySelector("#sobrenome");
const elementoIdade = document.querySelector("#idade");
const elementoBotao = document.querySelector("#alteraHumor");
const atributoNome = elementoBotao.getAttribute("data-nome");
const atributoSobrenome = elementoBotao.getAttribute("data-sobrenome")
const divSelec = document.querySelector("#div1")
console.log(divSelec.classList.contains('div-diferente'));
divSelec.classList.remove("div-separado");
divSelec.classList.remove("div-normal");
divSelec.classList.add("div-Ricardo");
console.log(atributoNome);
console.log(atributoSobrenome);


// Atribuir os valores iniciais
elementoNome.innerText = pessoa.nome;
elementoSobrenome.innerText = pessoa.sobrenome;
elementoIdade.innerText = pessoa.idade;

// Definição da função de atualização do humor
function atualizaHumor(){
    pessoa.doido = !pessoa.doido;
    const elementoImagem = document.querySelector("#imagem");
    const elementoHumor = document.querySelector("#bloco_humor");

    if (pessoa.doido){
        elementoImagem.src = pessoa.imagem_doido;
        elementoHumor.innerHTML = pessoa.nome + ' tá <b>DOIDO</b>!';
    }
    else{
        elementoImagem.src = pessoa.imagem_serio;
        elementoHumor.innerHTML = pessoa.nome + ' tá <b>SÉRIO</b>!';
    }
}

atualizaHumor();
// Adicionar o EventListener de clique no botão
elementoBotao.addEventListener('click', atualizaHumor);