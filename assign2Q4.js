/*
4)write a function to find max of  array number function should take array as a parameter
  and return max value*/
function MaxArray(arr) {
    var max = arr[0];
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}
var arr = new Array(12, 55, 22, 9, 11, 34, 78);
console.log(MaxArray(arr));
