import { Component, Input, OnInit, EventEmitter, ViewChild, Inject, forwardRef } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { MenuItem } from 'primeng/primeng';
import { AppComponent } from './app.component';

@Component({
	selector: 'app-menu',
	template: `
    <ul app-submenu [item]="model" root="true" class="ultima-menu ultima-main-menu clearfix" [reset]="reset"
        visible="true"></ul>
  `
})
export class AppMenuComponent implements OnInit {

	@Input() reset: boolean;

	model: any[];

	constructor(
		@Inject(forwardRef(() => AppComponent)) public app: AppComponent
	) {
	}

	ngOnInit() {
		this.model = [
			{
				label: 'Thống Kê',
				icon: 'dashboard',
				routerLink: ['/']
			},
			{
				label: 'Đơn Hàng',
				icon: 'insert_invitation',
				routerLink: ['/sale']
			},
			// {
			// 	label: 'Đơn Đặt Hàng',
			// 	icon: 'shopping_cart',
			// 	routerLink: ['/order']
			// },
			{
				label: 'Kho',
				icon: 'store',
				items: [
					{
						label: 'Kho',
						icon: 'send',
						routerLink: ['/warehouse']
					},
					{
						label: 'Danh Mục Kho',
						icon: 'send',
						routerLink: ['/category']
					},
					{
						label: 'Danh Mục Sản Phẩm',
						icon: 'send',
						routerLink: ['/product']
					},
					{
						label: 'Nhập Kho',
						icon: 'send',
						routerLink: ['/import']
					},
					{
						label: 'Xuất Kho',
						icon: 'send',
						routerLink: ['/export']
					},
					{
						label: 'Thẻ Kho',
						icon: 'send',
						routerLink: ['/warehouse-card']
					}
				]
			},
			{
				label: 'Khách Hàng',
				icon: 'supervisor_account',
				items: [
					{
						label: 'Danh Mục Khách Hàng',
						icon: 'send',
						routerLink: ['/customer']
					},
					{
						label: 'Công Nợ Khách Hàng',
						icon: 'send',
						routerLink: ['/customer-paid']
					}
				]
			},
			{
				label: 'Tài Khoản',
				icon: 'account_circle',
				routerLink: ['/account']
			},
			{
				label: 'Giao Hàng',
				icon: 'local_shipping',
				routerLink: ['/shipping']
			},
			{
				label: 'Báo Cáo',
				icon: 'assessment',
				items: [
					{
						label: 'Nhập Kho',
						icon: 'send',
						routerLink: ['/report-import']
					},
					{
						label: 'Xuất Kho',
						icon: 'send',
						routerLink: ['/report-export']
					},
					{
						label: 'Tồn Kho',
						icon: 'send',
						routerLink: ['/report-recent']
					},
					{
						label: 'Đơn Hàng',
						icon: 'send',
						routerLink: ['/report-sale']
					},
					{
						label: 'Giao Hàng',
						icon: 'send',
						routerLink: ['/report-shipping']
					},
					{
						label: 'Công Nợ Khách Hàng',
						icon: 'send',
						routerLink: ['/report-customer-paid']
					},
					{
						label: 'Doanh Thu',
						icon: 'send',
						routerLink: ['/report-profit']
					}
				]
			}
		];
	}

	changeTheme(theme) {
		let themeLink: HTMLLinkElement = <HTMLLinkElement>document.getElementById('theme-css');
		let layoutLink: HTMLLinkElement = <HTMLLinkElement>document.getElementById('layout-css');

		themeLink.href = 'assets/theme/theme-' + theme + '.css';
		layoutLink.href = 'assets/layout/css/layout-' + theme + '.css';
	}
}

@Component({
	selector: '[app-submenu]',
	template: `
    <ng-template ngFor let-child let-i="index" [ngForOf]="(root ? item : item.items)">
      <li [ngClass]="{'active-menuitem': isActive(i)}" *ngIf="child.visible === false ? false : true">
        <a [href]="child.url||'#'" (click)="itemClick($event,child,i)" class="ripplelink" *ngIf="!child.routerLink"
           [attr.tabindex]="!visible ? '-1' : null" [attr.target]="child.target">
          <i class="material-icons">{{child.icon}}</i>
          <span>{{child.label}}</span>
          <i class="material-icons" *ngIf="child.items">keyboard_arrow_down</i>
        </a>

        <a (click)="itemClick($event,child,i)" class="ripplelink" *ngIf="child.routerLink"
           [routerLink]="child.routerLink" routerLinkActive="active-menuitem-routerlink"
           [routerLinkActiveOptions]="{exact: true}" [attr.tabindex]="!visible ? '-1' : null"
           [attr.target]="child.target">
          <i class="material-icons">{{child.icon}}</i>
          <span>{{child.label}}</span>
          <i class="material-icons" *ngIf="child.items">keyboard_arrow_down</i>
        </a>
        <ul app-submenu [item]="child" *ngIf="child.items" [@children]="isActive(i) ? 'visible' : 'hidden'"
            [visible]="isActive(i)" [reset]="reset"></ul>
      </li>
    </ng-template>
  `,
	animations: [
		trigger('children', [
			state('hidden', style({
				height: '0px'
			})),
			state('visible', style({
				height: '*'
			})),
			transition('visible => hidden', animate('400ms cubic-bezier(0.86, 0, 0.07, 1)')),
			transition('hidden => visible', animate('400ms cubic-bezier(0.86, 0, 0.07, 1)'))
		])
	]
})
export class AppSubMenu {

	@Input() item: MenuItem;

	@Input() root: boolean;

	@Input() visible: boolean;

	_reset: boolean;

	activeIndex: number;

	constructor( @Inject(forwardRef(() => AppComponent)) public app: AppComponent, public router: Router, public location: Location) {
	}

	itemClick(event: Event, item: MenuItem, index: number) {
		// avoid processing disabled items
		if (item.disabled) {
			event.preventDefault();
			return true;
		}

		// activate current item and deactivate active sibling if any
		this.activeIndex = (this.activeIndex === index) ? null : index;

		// execute command
		if (item.command) {
			if (!item.eventEmitter) {
				item.eventEmitter = new EventEmitter();
				item.eventEmitter.subscribe(item.command);
			}

			item.eventEmitter.emit({
				originalEvent: event,
				item: item
			});
		}

		// prevent hash change
		if (item.items || (!item.url && !item.routerLink)) {
			event.preventDefault();
		}

		// hide menu
		if (!item.items) {
			if (this.app.isHorizontal()) {
				this.app.resetMenu = true;
			} else {
				this.app.resetMenu = false;
			}

			this.app.overlayMenuActive = false;
			this.app.staticMenuMobileActive = false;
		}
	}

	isActive(index: number): boolean {
		return this.activeIndex === index;
	}

	@Input() get reset(): boolean {
		return this._reset;
	}

	set reset(val: boolean) {
		this._reset = val;

		if (this._reset && this.app.isHorizontal()) {
			this.activeIndex = null;
		}
	}
}
