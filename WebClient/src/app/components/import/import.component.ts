import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'import',
	templateUrl: 'import.component.html'
})

export class ImportComponent implements OnInit {
	imports: [any];
	constructor() { }

	ngOnInit() { }
}