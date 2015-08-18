/*Write a script that converts a number in the range [0…999] to words,
  corresponding to its English pronunciation.*/
function numberAsWord() {
    var number = document.getElementById('num').value;
    var numWord = '';
    var numLenght = 0;
    if (number < 10) {
        numLenght = 1;
    }
    else if (number >= 10 && number < 100) {
        numLenght = 2;
    }
    else if (number >= 100 && number < 1000) {
        numLenght = 3;
    }
    else {
        numWord = 'you enter wrong number';
    }


    if (numLenght === 1) {
        switch (number) {
            case '0': numWord = 'Zero';
                break;
            case '1': numWord = 'One';
                break;
            case '2': numWord = 'Two';
                break;
            case '3': numWord = 'Three';
                break;
            case '4': numWord = 'Four';
                break;
            case '5': numWord = 'Five';
                break;
            case '6': numWord = 'Six';
                break;
            case '7': numWord = 'Seven';
                break;
            case '8': numWord = 'Eight';
                break;
            case '9': numWord = 'Nine';
                break;
        }
    }
    if (numLenght === 2) {
        if (Math.floor(number / 10)===1) {
            switch (number) {
                case '10': numWord = 'Ten';
                    break;
                case '11': numWord = 'Eleven';
                    break;
                case '12': numWord = 'Twelve';
                    break;
                case '13': numWord = 'Thirteen';
                    break;
                case '14': numWord = 'Fourteen';
                    break;
                case '15': numWord = 'Fifteen';
                    break;
                case '16': numWord = 'Sixteen';
                    break;
                case '17': numWord = 'Seventeen';
                    break;
                case '18': numWord = 'Eighteen';
                    break;
                case '19': numWord = 'Nineteen';
                    break;
            }
        }
        else {
            switch (Math.floor(number / 10)) {
                case 2: numWord = 'Twenty';
                    break;
                case 3: numWord = 'Thirty';
                    break;
                case 4: numWord = 'Fourty';
                    break;
                case 5: numWord = 'Fifty';
                    break;
                case 6: numWord = 'Sixty';
                    break;
                case 7: numWord = 'Seventy';
                    break;
                case 8: numWord = 'Eighty';
                    break;
                case 9: numWord = 'Ninety';
                    break;
            }
            switch (number % 10) {
                case 1: numWord += ' one';
                    break;
                case 2: numWord += ' two';
                    break;
                case 3: numWord += ' three';
                    break;
                case 4: numWord += ' four';
                    break;
                case 5: numWord += ' five';
                    break;
                case 6: numWord += ' six';
                    break;
                case 7: numWord += ' seven';
                    break;
                case 8: numWord += ' eight';
                    break;
                case 9: numWord += ' nine';
                    break;
            }
        }
    }
    if (numLenght === 3) {
        switch (Math.floor((number / 10) / 10)) {
            case 1: numWord = 'One hundred';
                break;
            case 2: numWord = 'Two hundred';
                break;
            case 3: numWord = 'Three hundred';
                break;
            case 4: numWord = 'Four hundred';
                break;
            case 5: numWord = 'Five hundred';
                break;
            case 6: numWord = 'Six hundred';
                break;
            case 7: numWord = 'Seven hundred';
                break;
            case 8: numWord = 'Eight hundred';
                break;
            case 9: numWord = 'Nine hundred';
                break;
        }
        
         if((Math.floor((number % 100) / 10)===1)){
            switch (Math.floor(number % 10)) {
                case 0: numWord += ' and ten';
                    break;
                case 1: numWord += ' and eleven';
                    break;
                case 2: numWord += ' and twelve';
                    break;
                case 3: numWord += ' and thirteen';
                    break;
                case 4: numWord += ' and fourteen';
                    break;
                case 5: numWord += ' and fifteen';
                    break;
                case 6: numWord += ' and sixteen';
                    break;
                case 7: numWord += ' and seventeen';
                    break;
                case 8: numWord += ' and eighteen';
                    break;
                case 9: numWord += ' and nineteen';
                    break;
            }
        }
         else if ((Math.floor((number % 100) / 10)) !== 1 && (Math.floor((number % 100) / 10)) !== 0) {
            switch (Math.floor((number % 100) / 10)) {
                case 2: numWord += ' and twenty';
                    break;
                case 3: numWord += ' and thirty';
                    break;
                case 4: numWord += ' and fourty';
                    break;
                case 5: numWord += ' and fifty';
                    break;
                case 6: numWord += ' and sixty';
                    break;
                case 7: numWord += ' and seventy';
                    break;
                case 8: numWord += ' and eighty';
                    break;
                case 9: numWord += ' and ninety';
                    break;
            }
            switch (number % 10) {
                case 1: numWord += ' one';
                    break;
                case 2: numWord += ' two';
                    break;
                case 3: numWord += ' three';
                    break;
                case 4: numWord += ' four';
                    break;
                case 5: numWord += ' five';
                    break;
                case 6: numWord += ' six';
                    break;
                case 7: numWord += ' seven';
                    break;
                case 8: numWord += ' eight';
                    break;
                case 9: numWord += ' nine';
                    break;
            }
         }
         else if ((Math.floor((number % 100) / 10)) === 0) {
             switch (number % 10) {
                 case 1: numWord += ' and one';
                     break;
                 case 2: numWord += ' and two';
                     break;
                 case 3: numWord += ' and three';
                     break;
                 case 4: numWord += ' and four';
                     break;
                 case 5: numWord += ' and five';
                     break;
                 case 6: numWord += ' and six';
                     break;
                 case 7: numWord += ' and seven';
                     break;
                 case 8: numWord += ' and eight';
                     break;
                 case 9: numWord += ' and nine';
                     break;
             }
         }
       
    }


    document.getElementById('numberAsWordRes').innerHTML = numWord;
    console.log(numWord);
}