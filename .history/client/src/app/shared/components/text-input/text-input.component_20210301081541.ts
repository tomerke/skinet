import { Component, ElementRef, Input, OnInit, ViewChild, Self } from '@angular/core';
import { ControlValueAccessor, NgControl } from '@angular/forms';

@Component({
  selector: 'app-text-input',
  templateUrl: './text-input.component.html',
  styleUrls: ['./text-input.component.scss']
})
export class TextInputComponent implements OnInit, ControlValueAccessor {
@ViewChild('input', {static: true}) input: ElementRef;
@Input() type = 'text';
@Input() label: string;

  constructor(@Self() public contrilDir: NgControl) {
    this.contrilDir.valueAccessor = this;
  }

  ngOnInit(): void {
    const control = this.contrilDir.control;
    const validators = control.validator ? [control.validator] : [];
    const asyncValidators = control.
  }

  onChange(event){
  }

  onTouched(){
  }

  writeValue(obj: any): void {
    this.input.nativeElement.value = obj || '';
  }

  registerOnChange(fn: any): void {
    this.onChange = fn;
  }
  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }



}
