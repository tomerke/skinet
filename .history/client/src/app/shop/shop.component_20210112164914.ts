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
  brandIdSelected = 0;
  typeIdSelected = 0;
  sortSelected = 'name';
  sortOptions = [
    {name:'Alphabetical', value : 'name'}
  ]

  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();
  }

  getProducts(){
    this.shopService.getProducts(this.brandIdSelected, this.typeIdSelected).subscribe(result =>{
      this.products = result.data;
      // console.error(JSON.stringify(this.products));
    }, error => {
      console.error(error);
    });
  }

  getBrands(){
    this.shopService.getBrands().subscribe(result =>{
      this.brands = [{id: 0, name: 'All'}, ...result];
    }, error => {
      console.error(error);
    });
  }

  getTypes(){
    this.shopService.getType().subscribe(result =>{
      this.types = [{id: 0, name: 'All'}, ...result];
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
