import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBrand } from '../shared/models/brand';
import { IPagination } from '../shared/models/pagination';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = "https://localhost:5001/api/";
  constructor(private http: HttpClient) { }


  getProducts(shopParams: Shop){
    let params   = new HttpParams();

    if (brandId){
    params = params.append('brandId', brandId.toString());
    }
    if (typeId){
     params = params.append('typeId', typeId.toString());
     }
     if (sort){
       params = params.append('sort', sort);
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
