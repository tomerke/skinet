import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequestCount = 0;

  constructor(private spinnerSrv: NgxSpinnerService) { }

  busy(){
    this.busyRequestCount++;
    this.spinnerSrv.show(undefined,)
  }
}
