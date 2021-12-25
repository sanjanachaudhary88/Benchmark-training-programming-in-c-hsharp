import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css']
})
export class AtmComponent implements OnInit {

  Balance:number=20000;


  constructor() { }

  ngOnInit(): void {
  }

  showbal()
  {
    console.log(this.Balance);
  }
  withdraw(amount:number)
  {
   
    this.Balance=this.Balance-amount;


  }
  deposite(amount:number)
  {
    this.Balance=this.Balance+amount;


  }

}
