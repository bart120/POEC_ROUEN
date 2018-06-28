// JavaScript source code
let uno = "01";
let dos = "02";

uno = Number(uno);
dos = Number(dos);

if (!Number.isNaN(uno) && !Number.isNaN(dos)) {
    console.log(uno + dos);
} else {
    console.log('Erreur de type');
}

