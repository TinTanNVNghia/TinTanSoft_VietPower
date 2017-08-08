import { Component } from '@angular/core';

import { ISale } from '../../models/ISale.interface';

@Component({
	selector: 'sale',
	templateUrl: './sale.component.html',
	styleUrls: ['./sale.component.css']
})

export class SaleComponent {

	displayDialog: boolean;

	sale: Sale = new Sale();

	selectedSale: Sale;

	newSale: Boolean;

	sales: [ISale] = [
		{
			Id: 1,
			SaleDate: new Date,
			Code: 'S001',
			CreatedBy: 'admin',
			UpdatedBy: 'admin',
			CustomerId: 1,
			CustomerName: 'Khach Hang',
			CustomerAddress: 'Dia Chi Khach Hang',
			CustomerPhone: '0123456789',
			ProductCode: 'P001',
			ProductId: 1,
			ProductName: 'Ten San Pham',
			CategoryName: 'Danh Muc San Pham',
			UnitCode: 'Cái',
			UnitId: 1,
			ProductForm: '30m x 20m x 10m',
			Production: 'Vinamilk',
			ProductPrice: 1000000,
			Quantity: 10,
			Total: 10000000,
			Paid: 5000000,
			Note: 'Giao Hang Trong 3 Ngay'
		}
	];

	constructor() {

	}

	showDialogToAdd() {
		this.newSale = true;
		this.sale = new Sale();
		this.displayDialog = true;
	}

	onRowSelect(event) {
		this.newSale = false;
		this.sale = this.cloneSale(event.data);
		this.displayDialog = true;
	}

	cloneSale(s: Sale) {
		let sale = new Sale();
		for (const prop in s) {
			sale[prop] = s[prop];
		}
		return sale;
	}

	findSelectedSaleIndex(): Number{
		return this.sales.indexOf(this.selectedSale);
	}
}

class Sale implements ISale {
	constructor() {

	}
}
