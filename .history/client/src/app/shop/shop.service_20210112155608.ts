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


  getProducts(brandId?: number, typeId?: number){
    const params = new HttpParams();
    let baseUrl = 'products';
    if (brandId){
      baseUrl = baseUrl +  '?brandId=' + brandId;
    //  params.append('brandId', brandId.toString());
      params.set('brandId', brandId.toString());
    }
    if (typeId){
      params.append('typeId', typeId.toString());
      baseUrl = baseUrl +  '?typeId=' + typeId;
      // console.error(JSON.stringify(typeId + "     " +brandId ))
    }
console.log()
    // return this.http.get<IPagination>(this.baseUrl + 'products', {observe: 'response', params}).pipe(
      return this.http.get<IPagination>(this.baseUrl + baseUrl, {observe: 'response'}).pipe(
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
