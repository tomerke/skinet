import { Component, Input, OnInit } from '@angular/core';
import { IBasketItem } from 'src/app/shared/models/basket';
import { IProduct } from 'src/app/shared/models/product';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})
export class ProductItemComponent implements OnInit {
@Input() product: IProduct;
  constructor(priavte basketService: ) { }

  ngOnInit(): void {
  }

}
