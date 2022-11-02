import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit {

  course:string = "Angular Spring Spring Boot"
  a: number = 0.259;
  b: number = 1.3495;
  today = new Date()
  pi: number = 3.14159265359;

  constructor() { }

  ngOnInit(): void {
  }

}
