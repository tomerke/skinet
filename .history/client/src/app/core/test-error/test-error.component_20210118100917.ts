import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-test-error',
  templateUrl: './test-error.component.html',
  styleUrls: ['./test-error.component.scss']
})
export class TestErrorComponent implements OnInit {
  baseUrl = environment.apiUrl;
  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  get404Error(){
    this.httpClient.get(this.baseUrl + 'products/42').subscribe(response => {
      console.error(response);
    }, error => {
      console.error(error);
    });
  }

  get500Error(){
    this.httpClient.get(this.baseUrl + 'buggy2').subscribe(response => {
      console.error(response);
    }, error => {
      console.error(error);
    });
  }

  get404Error(){
    this.httpClient.get(this.baseUrl + 'products/42').subscribe(response => {
      console.error(response);
    }, error => {
      console.error(error);
    });
  }

  get404Error(){
    this.httpClient.get(this.baseUrl + 'products/42').subscribe(response => {
      console.error(response);
    }, error => {
      console.error(error);
    });
  }
}
