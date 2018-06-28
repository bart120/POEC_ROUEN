// JavaScript source code
const text = 'Coucou 3';

//1
let regex = /[0-9]+/;
console.log(regex.exec(text));


//2
let regex2 = new RegExp('\\d');
console.log(regex2.exec(text));