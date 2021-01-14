import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IPagination } from '../shared/models/pagination';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = "https://localhost:5001/api/";
  constructor(private http: HttpClient) { }


  getProducts(){
    return this.http.get<IPagination>(this.baseUrl + 'products?pageSize=50');
  }

  getBrands(){
    return this.http.get<IBrand>(this.baseUrl + 'Products/brands');
  }


  getBrands(){
    return this.http.get<IBrand>(this.baseUrl + 'Products/brands');
  }

}
