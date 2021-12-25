function factorial(num1) {
    var result = 1;
    for (var i = 1; i <= num1; i++) {
        result = result * i;
    }
    console.log("factorial is " + result);
}
factorial(4);
