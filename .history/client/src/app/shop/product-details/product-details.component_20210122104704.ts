import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IProduct } from 'src/app/shared/models/product';
import { BreadcrumbService } from 'xng-breadcrumb';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
product: IProduct;

  constructor(private shopServe: ShopService, private activatedRoute: ActivatedRoute, private bcService: BreadcrumbService ) {
    this.bcService.set
   }

  ngOnInit(): void {
    this.loadProduct();
  }

  loadProduct(){
    this.shopServe.getproduct(+this.activatedRoute.snapshot.paramMap.get('id')).subscribe(product => {
      this.product = product;
      this.bcService.set('@productDetails', product.name);
  }, error => {
    console.error(error);
  });

}
}
