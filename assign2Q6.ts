/* 6)write a employee class with data constructor
eid
empname
deptno
salary
HRA
DA
gross salary
calculate gross salary on the base of
if basic salary <20000 then HRA 20% and  DA  80%
if basic salary   >20000 and<35000 then HRA 25% and DA 70%*/

class employee
{
    eid:number;
    empname:string;
    depno:number;
    basicsal:number;

    constructor(eid:number,empname:string,depno:number,basicsal:number)
    {
          this.eid=eid;
          this.empname=empname;
          this.depno=depno;
          this.basicsal=basicsal;
    }

     grosssal() 
    {
        
    
     
         let Hra;
         let Da;
         let sal;
         if(this.basicsal<=20000)
         {
              Hra=this.basicsal*0.80;
              Da=this.basicsal*0.20;
         }
         if(this.basicsal>20000 && this.basicsal<=35000)
         {
              Hra=this.basicsal*0.25;
              Da=this.basicsal*0.70;
         }
        sal=this.basicsal+Hra+Da;
        return sal;
    }
    display()
    {
        var sal1=this.grosssal();
        console.log("Employee id is "+this.eid);
        console.log("Employee name is "+this.empname);
        console.log("Employee department no is "+this.depno);
        console.log("Employee basic salary is "+this.basicsal);
        console.log("Employee total salary(basic+gross) is "+sal1);





    }
        
}

 let e= new employee(1,"priyanka",3,25000);
 e.display();
