import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  employees:any=[]
  displaysal:boolean=false
  loaded:boolean=false
  constructor() { }

  ngOnInit(): void {

    this.employees=[
      {
        code:1,
        name:'Ranga',
        dept:'IT',
        desg:'SE',
        sal:25000
      },
      {
        code:2,
        name:'Smitha',
        dept:'HR',
        desg:'Executive',
        sal:20000
      },
      {
        code:3,
        name:'Rajesh',
        dept:'Admin',
        desg:'Senior Executive',
        sal:30000
      },
      {
        code:4,
        name:'Smith',
        dept:'IT',
        desg:'Manager',
        sal:75000
      }
  
  ]
  this.loaded=true
  }

}
