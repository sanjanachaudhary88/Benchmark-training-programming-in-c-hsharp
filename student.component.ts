import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  Name:string="";
  RollNo:number=0;
  Ma:number=0;
  Sc:number=0;
  En:number=0;
  colspan:number=4;
  colspan1:number=3;
  rowspan:number=2;

  constructor() { }



  ngOnInit(): void {
  }

  percentage():number
  {
    let per:number;
    per=((this.Ma)+(this.En)+(this.Sc))/3;
    return per;
  }


}
