/*5) find the Array even  element sum and return it.*/
function ArraySum(arr) {
    var sum = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] % 2 == 0) {
            sum += arr[i];
        }
    }
    return sum;
}
var array = new Array(12, 78, 90, 1, 2, 3, 40, 133);
console.log("sum of even numbers in array is " + ArraySum(array));
