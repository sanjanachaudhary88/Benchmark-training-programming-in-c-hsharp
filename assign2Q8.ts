/* 8)write a class product
pid
pname
amount
discount
qty
calculate discount*/
class product
{
    pid:number;
    pname:string;
    amount:number;
    qty:number;

    accept(id:number,pna:string,am:number,qty:number):void
    {
      this.pid=id;
      this.pname=pna;
      this.amount=am;
      this.qty=qty;
    }
    discount():number
    {
        var bill;
        var dis;
        if(this.amount<=10000)
        {
           dis=this.amount-(this.amount*0.5);
           bill=dis*this.qty;

        }
        else if(this.amount>=10000 && this.amount<=20000)
        {
            dis=this.amount-(this.amount*0.10);
            bill=dis*this.qty;
        }
        else if(this.amount>=20000)
        {
            dis=this.amount-(this.amount*0.15);
            bill=dis*this.qty;
        }
        return bill;

    }
    display():void
    {
        console.log(this.pid);
        console.log(this.pname);
        console.log(this.amount);
        console.log(this.qty);
    }
   
    
}
let prod=new product();
prod.accept(12,"Tv",30000,2);
console.log("Product details are");
prod.display();
console.log("Bill amount after discount is "+prod.discount());