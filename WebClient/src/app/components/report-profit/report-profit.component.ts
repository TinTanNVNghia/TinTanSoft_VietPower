import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-profit',
	templateUrl: 'report-profit.component.html'
})

export class ReportProfitComponent implements OnInit {
	reportProfits: [any];
	constructor() { }

	ngOnInit() { }
}