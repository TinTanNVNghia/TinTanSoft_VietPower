import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-sale',
	templateUrl: 'report-sale.component.html'
})

export class ReportSaleComponent implements OnInit {
	reportSales: [any];
	constructor() { }

	ngOnInit() { }
}