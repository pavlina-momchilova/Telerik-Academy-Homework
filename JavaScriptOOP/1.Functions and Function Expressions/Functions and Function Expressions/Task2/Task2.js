/*
    Write a function that finds all the prime numbers in a range
    It should return the prime numbers in an array
    It must throw an Error if any of the range params is not convertible to Number
    It must throw an Error if any of the range params is missing
 */

function task2(from, to) {
        if (arguments.length < 2) {
            throw Error;
        }
        if (parseFloat(from)) {
            from = parseFloat(from);
        }
        else {
           // throw Error;
        }
        if (parseFloat(to)) {
            to = parseFloat(to);
        }
        else {
           // throw Error;
        }

        var primeNums = [], i, j, flag = true;
        if (from < 2) {
            from = 2;
        }

        for (i = from; i <= to; i += 1) {
            if (i === 2 || i===3 || i===5) {
                primeNums.push(i);
            }
            else {
                for (j = 2; j <= Math.floor(Math.sqrt(i)) ; j += 1) {
                    if (i % j === 0) {
                        flag = false;
                        break;
                    }
                }
                if (flag) {
                    primeNums.push(i);
                }
            }
           
        }
        return primeNums;
    }

console.log(task2(2, 5));