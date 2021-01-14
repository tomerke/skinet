import { Component, OnInit } from '@angular/core';
import { IProduct } from '../shared/models/product';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {

  products: IProduct[];
  constructor() { }

  ngOnInit(): void {
  }

}
