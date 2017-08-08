import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'customer-paid',
	templateUrl: 'customer-paid.component.html'
})

export class CustomerPaidComponent implements OnInit {
	customerPaids: [any];
	constructor() { }

	ngOnInit() { }
}