import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-error',
  templateUrl: './test-error.component.html',
  styleUrls: ['./test-error.component.scss']
})
export class TestErrorComponent implements OnInit {
  baseUrl=
  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  get404Error(){
    this.httpClient
  }

}
