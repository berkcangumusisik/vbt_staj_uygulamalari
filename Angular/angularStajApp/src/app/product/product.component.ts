import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ProductModel } from './models/product.model';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  name: string = 'Berkcan Gümüşışık';

  year: number = 2022;

  date: Date = new Date();

  bool: boolean = true;

  form: FormGroup = new FormGroup({
    name: new FormControl('Berkcan Reactive Form', Validators.required)
  });

  product: ProductModel = new ProductModel();

  constructor() {
        // this.setProduct();
        this.setProduct2();
  }

  ngOnInit(): void {

  }

  setProduct() {
    this.product.name = 'test Name';
    this.product.year = 2022;
    this.product.date = new Date();
    this.product.bool = true;
  }

  setProduct2() {
    this.product = {
      name : 'test Name',
      year : 2022,
      date : new Date(),
      bool : true
    }
  }

}
