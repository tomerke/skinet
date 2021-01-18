import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ShopComponent } from './shop.component';

const route: RouterModule =[
  {path: 'shop', component: ShopComponentonent},
  {path:'shop/:id', component: ProductDetailsComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ShopRoutingModule { }
