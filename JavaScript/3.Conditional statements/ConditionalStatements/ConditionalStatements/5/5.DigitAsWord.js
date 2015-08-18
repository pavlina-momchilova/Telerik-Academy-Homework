/*Write a script that asks for a digit (0-9), 
and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.*/
function digitAsWord(){
    var number = document.getElementById('num').value;
    var digitWord = '';
    switch (number) {
        case '0': digitWord = 'zero';
            break;
        case '1': digitWord = 'one';
            break;
        case '2': digitWord = 'two';
            break;
        case '3': digitWord = 'three';
            break;
        case '4': digitWord = 'four';
            break;
        case '5': digitWord = 'five';
            break;
        case '6': digitWord = 'six';
            break;
        case '7': digitWord = 'seven';
            break;
        case '8': digitWord = 'eight';
            break;
        case '9': digitWord = 'nine';
            break;
        default: digitWord = 'not a digit';
    }
    document.getElementById('digitAsWordRes').innerHTML = digitWord;
    console.log(digitWord);
}