import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'warehouse-card',
	templateUrl: 'warehouse-card.component.html'
})

export class WarehouseCardComponent implements OnInit {
	warehouseCards: [any];
	constructor() { }

	ngOnInit() { }
}