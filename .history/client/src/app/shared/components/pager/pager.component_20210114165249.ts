import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-pager',
  templateUrl: './pager.component.html',
  styleUrls: ['./pager.component.scss']
})
export class PagerComponent implements OnInit {
@Input() totalCount: number;
@Input() pageSize: number;
@Output() page

  constructor() { }

  ngOnInit(): void {
  }

}
