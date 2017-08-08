import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'export',
	templateUrl: 'export.component.html'
})

export class ExportComponent implements OnInit {
	exports: [any];
	constructor() { }

	ngOnInit() { }
}