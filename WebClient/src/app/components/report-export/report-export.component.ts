import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-export',
	templateUrl: 'report-export.component.html'
})

export class ReportExportComponent implements OnInit {
	reportExports: [any];
	constructor() { }

	ngOnInit() { }
}