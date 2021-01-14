import { Component, OnInit } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IProduct } from '../shared/models/product';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {
  brands: IBrand[];
  products: IProduct[];
type: IProductT

  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.shopService.getProducts().subscribe(result =>{
      this.products = result.data;
    }, error => {
      console.error(error);
    });
  }

  getProducts(){
    this.shopService.getProducts().subscribe(result =>{
      this.brands = result.data;
    }, error => {
      console.error(error);
    });
  }

  getBrandss(){
    this.shopService.getBrands().subscribe(result =>{
      this.products = result;
    }, error => {
      console.error(error);
    });
  }
}
