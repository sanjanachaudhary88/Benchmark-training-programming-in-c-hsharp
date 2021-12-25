/* 7)write a Student class in type script in following data member constructor
roll-no
name
marks[]//number
Percentage
Grade
write a method to display info and calculate  result and assign grade as per percentage*/

class Student
{
    rollno:number;
    sname:string;
    marks:number[];

    constructor(no:number,sname:string,marks:number[])
    {
        this.rollno=no;
        this.sname=sname;
        this.marks=marks;
    }
    display()
    {
            console.log("Student roll no is: "+this.rollno);
            console.log("Student name no is: "+this.sname);
            console.log("Student marks are:");
            for(let m in this.marks)
            {
                console.log(this.marks[m]);
            }



    }

    Percentage():number
    {
    
           let sum=0;
        var l=this.marks.length;
         for(let i=0;i<l;i++)
         {
           sum+=this.marks[i];
           
         }
         let per=sum/l;
    
         return per;
    }
    grade()
    {
        let percentage=this.Percentage();
        let grade;
        
         if(percentage<100 && percentage>=80)
            {
               grade="A";
             
            }
         else if(percentage<80 && percentage>=60)
            {
               grade="B";
                
            }

        
            else if(percentage<60 && percentage>=35)
            {
               grade="c";
                
            }
            else
            {
                grade="Fail";
            }
            return grade;
    }


}
var ma=new Array(60,90,67,68);
var s=new Student(1,"priya",ma);
console.log("Student Details are");
s.display();
console.log("Student obtained Percentage is: "+s.Percentage());
console.log("Student obtained grade is: "+s.grade());