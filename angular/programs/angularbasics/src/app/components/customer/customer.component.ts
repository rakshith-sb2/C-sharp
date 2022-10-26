import { Component, OnInit } from '@angular/core';

import {Customer} from '../../models/customer'

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  customers:Customer[]=[]
  constructor() { }

  ngOnInit(): void {

    this.customers=[
    {
      id:1,
      name:'Rohit',
      email:'rohit@gmail.com',
      mobile:9845547471,
      location:'Mumbai'
    },
    {
      id:2,
      name:'Rahul',
      email:'rahul@gmail.com',
      mobile:9845547472,
      location:'Bengaluru'
    },
    {
      id:3,
      name:'Virat',
      email:'virat@gmail.com',
      mobile:9845547473,
      location:'Delhi'
    }  
  ]
  }

}
