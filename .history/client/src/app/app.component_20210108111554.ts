import { Component ,OnInit} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{


  title = 'Skinet';
  constructor(private http:){
  }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}
