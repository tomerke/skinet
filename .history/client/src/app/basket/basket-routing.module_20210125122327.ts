import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes } from '@angular/router';
import { BasketComponent } from './basket.component';

const route: Routes = [{
  path: '', component: BasketComponent
}]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class BasketRoutingModule { }
