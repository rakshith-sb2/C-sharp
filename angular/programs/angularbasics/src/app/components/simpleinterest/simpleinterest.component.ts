import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-simpleinterest',
  templateUrl: './simpleinterest.component.html',
  styleUrls: ['./simpleinterest.component.css']
})
export class SimpleinterestComponent implements OnInit {

  principal:number | any;
  roi:number|any;
  time:number|any;
  si:number|any;
  
  constructor() { }

  ngOnInit(): void {
  }

  CalculateSI():void{
    this.si = (this.principal*this.roi*this.time)/100;
  }

}
