import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'product',
	templateUrl: 'product.component.html'
})

export class ProductComponent implements OnInit {
	products: [any];
	constructor() { }

	ngOnInit() { }
}