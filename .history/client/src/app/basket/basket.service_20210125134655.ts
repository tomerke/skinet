import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { publishBehavior } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BasketService {
  baseUrl = environment.apiUrl;
  private basketSource = new publishBehavior

  constructor(private httpClient: HttpClient) { }


}
