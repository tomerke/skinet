import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes } from '@angular/router';
import { Ng } from '@angular/router';

const route: Routes =[
  {'path':'', component: BasketComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class BasketRoutingModule { }
