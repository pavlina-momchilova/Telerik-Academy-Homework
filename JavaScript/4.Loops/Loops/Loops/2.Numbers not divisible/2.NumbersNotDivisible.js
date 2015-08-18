function NumbersNotDivisible(){
    var n = document.getElementById('n').value;
    var result = ' ';
    console.log(n);

    for (var i = 1; i < n; i++) {
        if (i % 3!==0 || i % 7!==0) {
            result += i + ' ';
        }
    }

    document.getElementById('result').innerHTML = result;
    console.log(result);
}