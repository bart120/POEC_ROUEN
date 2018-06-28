// JavaScript source code
let number = { random: "1" };

number.random =  () => {
    return Math.round( Math.random() * 100);
}


console.log(number.random());