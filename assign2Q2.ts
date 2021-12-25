function calculate_discountbill(amt:number){
    var result=0;
    if(amt<10000){
        result=amt*(5/100);
        console.log(result);
    
    }
    
    else  if(amt>10000 && amt<20000){
        result=amt*(10/100);
        console.log(result);
    }
    else  if(amt>20000 && amt<30000){
        result=amt*(15/100);
        console.log(result);
    }
    else  if(amt<30000){
        result=amt*(25/100);
        console.log(result);
    }
    else{
        console.log("invalid input");
    }
}
calculate_discountbill(25000);