const form = document.querySelector('form');
const input = document.querySelector('#pokemon-name');
const pokemonImage = document.querySelector('#pokemon-image');
const pokemonName = document.querySelector('#pokemon-name-info');
const pokemonType = document.querySelector('#pokemon-type');
const pokemonAbility = document.querySelector('#pokemon-ability');
const pokemonHeight = document.querySelector('#pokemon-height');
const pokemonWeight = document.querySelector('#pokemon-weight');

const fetchPokemonData = async (pokemonName) => {
	try {
		const response = await fetch(
			`https://pokeapi.co/api/v2/pokemon/${pokemonName}`
		);
		const data = await response.json();
		return data;
	} catch (error) {
		console.log(error);
	}
};

const displayPokemonData = (pokemonData) => {
	pokemonImage.src = pokemonData.sprites.front_default;
	pokemonName.textContent = pokemonData.name;
	pokemonType.textContent = `Type: ${pokemonData.types[0].type.name}`;
	pokemonAbility.textContent = `Ability: ${pokemonData.abilities[0].ability.name}`;
	pokemonHeight.textContent = `Height: ${pokemonData.height} m`;
	pokemonWeight.textContent = `Weight: ${pokemonData.weight} kg`;
};

form.addEventListener('submit', async (event) => {
	event.preventDefault();
	const pokemonNameValue = input.value.trim().toLowerCase();
	if (pokemonNameValue !== '') {
		const pokemonData = await fetchPokemonData(pokemonNameValue);

		if (pokemonData) {
			displayPokemonData(pokemonData);
			input.value = '';
		}
	}
});
