import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes } from '@angular/router';

const route: Routes = [{
  path: '', component: BasketComponen
}]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class BasketRoutingModule { }
