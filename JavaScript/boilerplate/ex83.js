// JavaScript source code
let personnes = {
    profs: [
        { prenom: 'Han', nom: 'Solo' },
        { prenom: 'Chew', nom: 'Bacca' }
    ],
    eleves: [
        { prenom: 'Marty', nom: 'McFly' },
        { prenom: 'Doc', nom: 'Brown' }
    ]
};

console.log(personnes['eleves'][0]['prenom']);
console.log(personnes.eleves[0].prenom);