import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  
  Number1:number=0;
  Number2:number=0;



  constructor() { }

  ngOnInit(): void {
  }
  add():number
  {
    return (this.Number1+this.Number2);
  }
  sub():number
  {
    return this.Number1-this.Number2;
  }
  mul():number
  {
    return this.Number1*this.Number2;
  }
  div():number
  {
    return (this.Number1/this.Number2);
  }
}
