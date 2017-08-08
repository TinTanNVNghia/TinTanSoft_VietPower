import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-shipping',
	templateUrl: 'report-shipping.component.html'
})

export class ReportShippingComponent implements OnInit {
	reportShippings: [any];
	constructor() { }

	ngOnInit() { }
}