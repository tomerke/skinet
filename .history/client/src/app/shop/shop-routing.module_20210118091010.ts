import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

const route: RouterModulete =[
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
