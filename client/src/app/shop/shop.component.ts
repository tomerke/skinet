import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IProduct } from '../shared/models/product';
import { IType } from '../shared/models/productType';
import { ShopParams } from '../shared/models/shopParams';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss'],
})
export class ShopComponent implements OnInit {
 @ViewChild('search', {static: false}) searchTerm: ElementRef;
  brands: IBrand[];
  products: IProduct[];
  types: IType[];
  shopParams = new ShopParams();
  totalCount: number;
  sortOptions = [
    { name: 'Alphabetical', value: 'name' },
    { name: 'Price Low to High', value: 'priceAsc' },
    { name: 'Price High to Low', value: 'priceDesc' },
  ];

  constructor(private shopService: ShopService) {}

  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();
  }

  getProducts() {
    this.shopService.getProducts(this.shopParams).subscribe(
      (result) => {
        this.products = result.data;
        this.shopParams.pageNumber = result.pageIndex;
        this.shopParams.pageSize = result.pageSize;
        this.totalCount = result.count;
        // console.error(JSON.stringify(this.products));
      },
      (error) => {
        console.error(error);
      }
    );
  }

  getBrands() {
    this.shopService.getBrands().subscribe(
      (result) => {
        this.brands = [{ id: 0, name: 'All' }, ...result];
      },
      (error) => {
        console.error(error);
      }
    );
  }

  getTypes() {
    this.shopService.getType().subscribe(
      (result) => {
        this.types = [{ id: 0, name: 'All' }, ...result];
      },
      (error) => {
        console.error(error);
      }
    );
  }

  onBrandIdSelected(brandId: number) {
    this.shopParams.brandId = brandId;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onTypeSelected(typeID: number) {
    this.shopParams.typeId = typeID;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onSortSelected(sort: string) {
    this.shopParams.sort = sort;
    this.getProducts();
  }

  onPageChanged(event: any) {
    if (this.shopParams.pageNumber !== event){
      this.shopParams.pageNumber = event;
      this.getProducts();
    }
  }

  onSearch(){
    // console.error(this.searchTerm.nativeElement.value)
    this.shopParams.search = this.searchTerm.nativeElement.value;
    this.shopParams.pageNumber = 1;
    this.getProducts();
  }

  onReset(){
    // console.error("onReset")
    this.searchTerm.nativeElement.value = '';
    this.shopParams = new ShopParams();
    this.getProducts();
  }
}
