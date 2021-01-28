import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes } from '@angular/router';
import { CheckoutComponent } from './checkout.component';

const routes: Routes = [{
  path:'', component:CheckoutComponent
}]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class CheckoutRoutingModule { }
