import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'shipping',
	templateUrl: 'shipping.component.html'
})

export class ShippingComponent implements OnInit {
	shippings: [any];
	constructor() { }

	ngOnInit() { }
}