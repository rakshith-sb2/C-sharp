import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  addEmployeeRequest:Employee={
    id:'',
    name:'',
    email:'',
    phone:0,
    salary:0,
    department:''
  }
  constructor(private employeeService:EmployeesService) { }

  ngOnInit(): void {
  }

  addEmployee(){
    
    // console.log(this.addEmployeeRequest.id);
    // console.log(this.addEmployeeRequest.name);
    // console.log(this.addEmployeeRequest.email);
    // console.log(this.addEmployeeRequest.salary);
    // console.log(this.addEmployeeRequest.department);
    this.employeeService.addEmployee(this.addEmployeeRequest)
    .subscribe({
        next:(employee)=>{console.log(employee);}
      })
  }
  

}
