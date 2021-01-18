import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
product: IProduct;

  constructor(private shopServe: ShopService, private activateRoute: Ac ) { }

  ngOnInit(): void {
    this.loadProduct();
  }

  loadProduct(){
    this.shopServe.getproduct(2).subscribe(product => {
      this.product = product;
  }, error => {
    console.error(error);
  });

}
}
