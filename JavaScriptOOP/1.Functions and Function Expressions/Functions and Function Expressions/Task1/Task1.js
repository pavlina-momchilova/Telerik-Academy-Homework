/*
    Write a function that sums an array of numbers:
    Numbers must be always of type Number
    Returns null if the array is empty
    Throws Error if the parameter is not passed (undefined)
    Throws if any of the elements is not convertible to Number
 */

function task1(arr) {
    if(arguments.length===0){
        throw Error;
    }
    else{
        var sum = 0, len = arr.length, i;
            if (len === 0) {
                return null;
            }
            else {
                for (i = 0; i < len; i += 1) {
                    if(parseFloat(arr[i])){
                        arr[i]=parseFloat(arr[i]);
                    }
                    else{
                        throw Error;
                    }
                    sum+=arr[i];
                }
            }
            return sum;
    }
}

console.log(task1([2,6,7,8,'10']));