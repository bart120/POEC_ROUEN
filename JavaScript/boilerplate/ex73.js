// JavaScript source code
const dt = new Date(2018, 9, 25);

console.log(dt.toLocaleDateString('fr-FR', {
    day: 'numeric',
    year: 'numeric',
    month: 'short'
}));