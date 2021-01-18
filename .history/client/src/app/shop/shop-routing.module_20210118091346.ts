import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ShopComponent } from './shop.component';
import { ProductDetailsComponent } from './product-details/product-details.component';

const route: RouterModule = [
  {path: '', component: ShopComponent},
  {path: ':id', component: ProductDetailsComponent}
];


@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild
  ]
})
export class ShopRoutingModule { }
