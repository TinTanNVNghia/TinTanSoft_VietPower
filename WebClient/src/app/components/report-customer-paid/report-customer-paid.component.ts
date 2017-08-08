import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-customer-paid',
	templateUrl: 'report-customer-paid.component.html'
})

export class ReportCustomerPaidComponent implements OnInit {
	reportCustomerPaids: [any];
	constructor() { }

	ngOnInit() { }
}