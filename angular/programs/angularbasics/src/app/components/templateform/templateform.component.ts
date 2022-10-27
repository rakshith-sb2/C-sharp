import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-templateform',
  templateUrl: './templateform.component.html',
  styleUrls: ['./templateform.component.css']
})
export class TemplateformComponent implements OnInit {

  regUsers:any[]=[]
  constructor() { }

  ngOnInit(): void {
  }

  register(data:NgForm):void{
    console.log('register')
    console.log(data.value)
    console.log('Name: ' +data.value.name)
    console.log('Name:using control ' +data.controls['name'].value)
    this.regUsers.push(data.value)
  }

}
