import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'warehouse',
	templateUrl: './warehouse.component.html',
	styleUrls: ['./warehouse.component.css']
})

export class WarehouseComponent implements OnInit {
	warehouses: [any];

	constructor() {

	}
	ngOnInit(): void {

	}
}
