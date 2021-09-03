const cardPokemons = document.querySelectorAll(".card_pokemon");
const pokemonSelecionado = document.querySelector("#pokemon_selecionado");

function selecionaPokemon(){
    const nomePokemon = this.getAttribute("data-nome");

    if(!this.classList.contains("selecionado")){
        this.classList.add("selecionado");
        pokemonSelecionado.innerHTML = `O último Pokemon selecionado foi o <b>${nomePokemon}</b>`; // APÓSTROFES!
        //pokemonSelecionado.innerHTML = "O último Pokemon selecionado foi o <b>"+nomePokemon+"</b>";
    }
    else {
        this.classList.remove("selecionado");

        const pokemonsSelecionados = document.querySelectorAll(".selecionado")
        if (pokemonsSelecionados.length >= 1){ // len(lista) DO PYTHON
            pokemonSelecionado.innerHTML = `Você desselecionou o pokemon ${nomePokemon}. Ainda resta(m) ${pokemonsSelecionados.length} selecionado(s).`
        } 
        else {
            pokemonSelecionado.innerHTML = "Selecione um Pokemon"
        }
    }
}

for(const cardPokemon of cardPokemons){
    cardPokemon.addEventListener("click", selecionaPokemon)
}