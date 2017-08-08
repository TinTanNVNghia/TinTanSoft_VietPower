import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'report-import',
	templateUrl: 'report-import.component.html'
})

export class ReportImportComponent implements OnInit {
	reportImports: [any];
	constructor() { }

	ngOnInit() { }
}