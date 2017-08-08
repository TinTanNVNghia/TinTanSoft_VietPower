import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'customer',
	templateUrl: 'customer.component.html'
})

export class CustomerComponent implements OnInit {
	customers: [any];
	constructor() { }

	ngOnInit() { }
}