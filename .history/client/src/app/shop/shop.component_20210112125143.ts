import { Component, OnInit } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IProduct } from '../shared/models/product';
import { IType } from '../shared/models/productType';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {
  brands: IBrand[];
  products: IProduct[];
  types: IType[];
  brandIdSelected: number;
  typeIdSelected: number;

  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();
  }

  getProducts(){
    this.shopService.getProducts(this.brandIdSelected, this.typeIdSelected).subscribe(result =>{
      this.products = result.data;
    }, error => {
      console.error(error);
    });
  }

  getBrands(){
    this.shopService.getBrands().subscribe(result =>{
      this.brands = [{id:0, }];
    }, error => {
      console.error(error);
    });
  }

  getTypes(){
    this.shopService.getType().subscribe(result =>{
      this.types = result;
    }, error => {
      console.error(error);
    });
  }

  onBrandIdSelected(brandId: number){
    this.brandIdSelected = brandId;
    this.getProducts();
  }

  onTypeSelected(typeID: number){
    this.typeIdSelected = typeID;
    this.getProducts();
  }

}
