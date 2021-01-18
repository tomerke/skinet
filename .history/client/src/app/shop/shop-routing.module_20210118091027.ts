import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ShopComponent } from './shop.component';
import { ProductDetailsComponent } from './product-details/product-details.component';

const route: RouterModule =[
  {path: 'shop', component: ShopComponent},
  {path:'shop/:id', component: ProductDetailsComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ShopRoutingModule { }
