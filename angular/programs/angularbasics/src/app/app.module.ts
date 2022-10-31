import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypesComponent } from './datatypes/datatypes.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { CustomerComponent } from './components/customer/customer.component';
import { DatabindingComponent } from './components/databinding/databinding.component';
import {FormsModule} from '@angular/forms';
import { SimpleinterestComponent } from './components/simpleinterest/simpleinterest.component';
import { SwitchdemoComponent } from './components/switchdemo/switchdemo.component';
import { StyledemoComponent } from './components/styledemo/styledemo.component';
import { ClassdemoComponent } from './components/classdemo/classdemo.component';
import { TemplateformComponent } from './components/templateform/templateform.component';
import { CoronaComponent } from './components/corona/corona.component';
import {HttpClientModule} from '@angular/common/http';
import { TodosComponent } from './components/todos/todos.component';
import { ParentComponent } from './components/parent/parent.component';
import { ChildComponent } from './components/child/child.component'

@NgModule({
  declarations: [
    AppComponent,
    DatatypesComponent,
    EmployeeComponent,
    CustomerComponent,
    DatabindingComponent,
    SimpleinterestComponent,
    SwitchdemoComponent,
    StyledemoComponent,
    ClassdemoComponent,
    TemplateformComponent,
    CoronaComponent,
    TodosComponent,
    ParentComponent,
    ChildComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
