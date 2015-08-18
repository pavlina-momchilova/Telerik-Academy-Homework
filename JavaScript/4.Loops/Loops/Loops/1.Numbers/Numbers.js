function Numbers() {
    var n = document.getElementById('n').value;
    var result = ' ';
    
    for (var i = 1; i <= n; i++) {
        result += i+' ';
    }


    document.getElementById('result').innerHTML = result;
    console.log(result);
}