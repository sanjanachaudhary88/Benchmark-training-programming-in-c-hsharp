/*1) Write a typescript function to perform arithmetic operation
Function should have 3 arg op1,op2,operator*/
function calculate(No1, No2, opr) {
    var ans;
    if (opr.charAt(0) == "+") {
        ans = No1 + No2;
    }
    else if (opr.charAt(0) == "-") {
        ans = No1 - No2;
    }
    else if (opr.charAt(0) == "/") {
        if (No1 != 0) {
            ans = No1 / No2;
        }
        else {
            ans = 0;
        }
    }
    else if (opr.charAt(0) == "*") {
        ans = No1 * No2;
    }
    else {
        ans = "Invalid";
    }
    console.log(ans);
}
calculate(60, 12, "*");
