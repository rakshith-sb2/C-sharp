import { Component, OnInit } from '@angular/core';

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

  constructor() {
    console.log('DatatypesComponent:constructor')
   }

  ngOnInit(): void {
    console.log('DatatypesComponent:ngOnInit')
  }

  greet():string{
    return 'Deepavali Greetings'
  }

}
