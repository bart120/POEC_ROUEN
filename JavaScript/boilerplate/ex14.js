// JavaScript source code
/*
let compteur = 0;
let timer = setInterval(show, 1000);

function show() {
    console.log('coucou');
    //compteur = compteur + 1;
    compteur++;
    if (compteur == 3) {
        clearInterval(timer);
    }
}*/

var compteur = 0;
let timer = setInterval(() => {
    console.log('coucou');
    compteur++;
    if (compteur == 3) {
        clearInterval(timer);
    }
}, 1000)
