import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { BasketService } from 'src/app/basket/basket.service';
import { CheckoutService } from '../checkout.service';

@Component({
  selector: 'app-checkout-payment',
  templateUrl: './checkout-payment.component.html',
  styleUrls: ['./checkout-payment.component.scss']
})
export class CheckoutPaymentComponent implements OnInit {
@Input() checkoutForm: FormGroup;

  constructor(private basketService: BasketService, private checkoutService: CheckoutService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  submitOrder(){
    const basket = this.basketService.getCurrentBasketValue();
    const order
  }

}
