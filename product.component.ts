import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  Name:string="";
  Price:number=0;
  Dis:number=0;
  Qty:number=0;

  constructor() { }

  ngOnInit(): void {
  }

  Bill():number
  {
    let bill:number;
    let dis1:number;
    dis1=this.Price*(this.Dis/100);
    bill=(this.Price-dis1)*this.Qty;
    return bill;
  }

}
