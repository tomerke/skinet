import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IPagination } from '../shared/models/pagination';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';
import { ShopParams } from '../shared/models/shopParams';


@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = "https://localhost:5001/api/";
  constructor(private http: HttpClient) { }


  getProducts(shopParams: ShopParams){
    let params   = new HttpParams();

    if (shopParams.brandId !== 0){
    params = params.append('brandId', shopParams.brandId.toString());
    }
    if (shopParams.typeId !== 0){
     params = params.append('typeId', shopParams.typeId.toString());
     }
     if (shopParams.sort){
       params = params.append('sort', shopParams.sort);
     }

    return this.http.get<IPagination>(this.baseUrl + 'products', {observe: 'response', params}).pipe(
      map(response => {
      return  response.body;
      })
    );
  }

  getBrands(){
    return this.http.get<IBrand[]>(this.baseUrl + 'Products/brands');
  }


  getType(){
    return this.http.get<IType[]>(this.baseUrl + 'Products/types');
  }

}