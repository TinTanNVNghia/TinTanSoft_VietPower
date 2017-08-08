import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'account',
	templateUrl: 'account.component.html'
})

export class AccountComponent implements OnInit {
	accounts: [any];
	constructor() { }

	ngOnInit() { }
}