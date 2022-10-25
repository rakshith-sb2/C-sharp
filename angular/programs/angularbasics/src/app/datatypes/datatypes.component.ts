import { Component, OnInit } from '@angular/core';
import { TitleStrategy } from '@angular/router';

@Component({
  selector: 'app-datatypes',
  templateUrl: './datatypes.component.html',
  styleUrls: ['./datatypes.component.css']
})
export class DatatypesComponent implements OnInit {
  /**
  age = 10
  age='ten';
 */
  /**
   * Type script data types
   * string,number,boolean
   */
  course:string='Angular'
  duration:number = 20
  isRegistered:boolean=true
  credit:number = 3.5
  courses:string[]=['HTML','CSS','Java Script','C#']
  student={
    id:1,
    name:'ravi',
    location:'Bengaluru'
  }

  students=[

    {
      id:1,
      name:'ravi',
      location:'Bengaluru'
    },
    {
      id:1,
      name:'ravi',
      location:'Bengaluru'
    }
  ]
  // any is like  var in javascript
  anytype:any='any thing can be assignment'

  undefinedtype:undefined;
  counter:number=0;
  constructor() {
    console.log('DatatypesComponent:constructor')
   }

  ngOnInit(): void {
    console.log('DatatypesComponent:ngOnInit')
  }

  greet():string{
    return 'Deepavali Greetings'
  }

  buttonClicked():number{

    this.counter=this.counter+1;
    return this.counter;


  }

}
