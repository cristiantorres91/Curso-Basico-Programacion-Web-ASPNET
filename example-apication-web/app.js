let items = [];

const renderItems = () => {
	const list = document.querySelector('#items');
	list.innerHTML = '';
	items.forEach((item, index) => {
		const li = document.createElement('li');
		li.innerHTML = `
      <span>${item.text}</span>
      <button data-index="${index}">x</button>
    `;
		if (item.completed) {
			li.classList.add('completed');
		}
		list.appendChild(li);
	});
};

const addItem = (event) => {
	event.preventDefault();
	const input = document.querySelector('#new-item');
	const text = input.value.trim();
	if (text) {
		items.push({ text, completed: false });
		input.value = '';
		renderItems();
	}
};

const removeItem = (event) => {
	event.preventDefault();
	items = items.filter((item) => !item.completed);
	renderItems();
};

const toggleItem = (event) => {
	const index = event.target.dataset.index;
	if (index !== undefined) {
		items[index].completed = !items[index].completed;
		renderItems();
	}
};

const addButton = document.querySelector('#add-btn');
addButton.addEventListener('click', addItem);

const removeButton = document.querySelector('#remove-btn');
removeButton.addEventListener('click', removeItem);

const list = document.querySelector('#items');
list.addEventListener('click', toggleItem);
