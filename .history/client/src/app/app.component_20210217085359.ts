import { Component, OnInit} from '@angular/core';
import { AccountService } from './account/account.service';
import { BasketService } from './basket/basket.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{



  constructor(private basketService: BasketService, private accountService: AccountService){
  }

  ngOnInit(): void {
    this.loadBasket();
  }

  loadBasket(){
    const basketId = localStorage.getItem('basket_id');
    if (basketId){
      this.basketService.getBasket(basketId).subscribe(() => {
        // console.log('initialised basket');
      }, error =>{
        console.error(error);
      });
    }
  }

  loadingCurrentUser(){
    const token = localStorage.getItem('token');
    if (token){
      this.accountService.loadCurrentUser(token).subscribe(()=>{
        console.log
      })
    }
  }

}
