import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

const route: Route =[
  {path: 'shop', component: ShopComponent},
  {path:'shop/:id', component: ProductDetailsComponent},
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ShopRoutingModule { }
