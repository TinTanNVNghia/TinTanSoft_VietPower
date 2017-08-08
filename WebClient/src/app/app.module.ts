import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { AppRoutes } from './app.routes';
import 'rxjs/add/operator/toPromise';

/* Primefaces Module */
import { AccordionModule } from 'primeng/primeng';
import { AutoCompleteModule } from 'primeng/primeng';
import { BreadcrumbModule } from 'primeng/primeng';
import { ButtonModule } from 'primeng/primeng';
import { CalendarModule } from 'primeng/primeng';
import { CarouselModule } from 'primeng/primeng';
import { ChartModule } from 'primeng/primeng';
import { CheckboxModule } from 'primeng/primeng';
import { ChipsModule } from 'primeng/primeng';
import { CodeHighlighterModule } from 'primeng/primeng';
import { ConfirmDialogModule } from 'primeng/primeng';
import { SharedModule } from 'primeng/primeng';
import { ContextMenuModule } from 'primeng/primeng';
import { DataGridModule } from 'primeng/primeng';
import { DataListModule } from 'primeng/primeng';
import { DataScrollerModule } from 'primeng/primeng';
import { DataTableModule } from 'primeng/primeng';
import { DialogModule } from 'primeng/primeng';
import { DragDropModule } from 'primeng/primeng';
import { DropdownModule } from 'primeng/primeng';
import { EditorModule } from 'primeng/primeng';
import { FieldsetModule } from 'primeng/primeng';
import { FileUploadModule } from 'primeng/primeng';
import { GalleriaModule } from 'primeng/primeng';
import { GMapModule } from 'primeng/primeng';
import { GrowlModule } from 'primeng/primeng';
import { InputMaskModule } from 'primeng/primeng';
import { InputSwitchModule } from 'primeng/primeng';
import { InputTextModule } from 'primeng/primeng';
import { InputTextareaModule } from 'primeng/primeng';
import { LightboxModule } from 'primeng/primeng';
import { ListboxModule } from 'primeng/primeng';
import { MegaMenuModule } from 'primeng/primeng';
import { MenuModule } from 'primeng/primeng';
import { MenubarModule } from 'primeng/primeng';
import { MessagesModule } from 'primeng/primeng';
import { MultiSelectModule } from 'primeng/primeng';
import { OrderListModule } from 'primeng/primeng';
import { OverlayPanelModule } from 'primeng/primeng';
import { PaginatorModule } from 'primeng/primeng';
import { PanelModule } from 'primeng/primeng';
import { PanelMenuModule } from 'primeng/primeng';
import { PasswordModule } from 'primeng/primeng';
import { PickListModule } from 'primeng/primeng';
import { ProgressBarModule } from 'primeng/primeng';
import { RadioButtonModule } from 'primeng/primeng';
import { RatingModule } from 'primeng/primeng';
import { ScheduleModule } from 'primeng/primeng';
import { SelectButtonModule } from 'primeng/primeng';
import { SlideMenuModule } from 'primeng/primeng';
import { SliderModule } from 'primeng/primeng';
import { SpinnerModule } from 'primeng/primeng';
import { SplitButtonModule } from 'primeng/primeng';
import { StepsModule } from 'primeng/primeng';
import { TabMenuModule } from 'primeng/primeng';
import { TabViewModule } from 'primeng/primeng';
import { TerminalModule } from 'primeng/primeng';
import { TieredMenuModule } from 'primeng/primeng';
import { ToggleButtonModule } from 'primeng/primeng';
import { ToolbarModule } from 'primeng/primeng';
import { TooltipModule } from 'primeng/primeng';
import { TreeModule } from 'primeng/primeng';
import { TreeTableModule } from 'primeng/primeng';

import { AppComponent } from './app.component';
import { AppMenuComponent, AppSubMenu } from './app.menu.component';
import { AppTopBar } from './app.topbar.component';
import { AppFooter } from './app.footer.component';
import { InlineProfileComponent } from './app.profile.component';

/* VietPower Component */
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { SaleComponent } from './components/sale/sale.component';
import { OrderComponent } from './components/order/order.component';
import { WarehouseComponent } from './components/warehouse/warehouse.component';
import { AccountComponent } from './components/account/account.component';
import { CategoryComponent } from './components/category/category.component';
import { CustomerComponent } from './components/customer/customer.component';
import { CustomerPaidComponent } from './components/customer-paid/customer-paid.component';
import { ExportComponent } from './components/export/export.component';
import { ImportComponent } from './components/import/import.component';
import { ProductComponent } from './components/product/product.component';
import { ReportCustomerPaidComponent } from './components/report-customer-paid/report-customer-paid.component';
import { ReportExportComponent } from './components/report-export/report-export.component';
import { ReportImportComponent } from './components/report-import/report-import.component';
import { ReportProfitComponent } from './components/report-profit/report-profit.component';
import { ReportRecentComponent } from './components/report-recent/report-recent.component';
import { ReportSaleComponent } from './components/report-sale/report-sale.component';
import { ReportShippingComponent } from './components/report-shipping/report-shipping.component';
import { ShippingComponent } from './components/shipping/shipping.component';
import { WarehouseCardComponent } from './components/warehouse-card/warehouse-card.component';

/* VietPower Service */
import { HttpService } from './services/http.service';
import { AuthService } from './services/auth.service';

@NgModule({
	imports: [
		BrowserModule,
		FormsModule,
		AppRoutes,
		HttpModule,
		BrowserAnimationsModule,
		AccordionModule,
		AutoCompleteModule,
		BreadcrumbModule,
		ButtonModule,
		CalendarModule,
		CarouselModule,
		ChartModule,
		CheckboxModule,
		ChipsModule,
		CodeHighlighterModule,
		ConfirmDialogModule,
		SharedModule,
		ContextMenuModule,
		DataGridModule,
		DataListModule,
		DataScrollerModule,
		DataTableModule,
		DialogModule,
		DragDropModule,
		DropdownModule,
		EditorModule,
		FieldsetModule,
		FileUploadModule,
		GalleriaModule,
		GMapModule,
		GrowlModule,
		InputMaskModule,
		InputSwitchModule,
		InputTextModule,
		InputTextareaModule,
		LightboxModule,
		ListboxModule,
		MegaMenuModule,
		MenuModule,
		MenubarModule,
		MessagesModule,
		MultiSelectModule,
		OrderListModule,
		OverlayPanelModule,
		PaginatorModule,
		PanelModule,
		PanelMenuModule,
		PasswordModule,
		PickListModule,
		ProgressBarModule,
		RadioButtonModule,
		RatingModule,
		ScheduleModule,
		SelectButtonModule,
		SlideMenuModule,
		SliderModule,
		SpinnerModule,
		SplitButtonModule,
		StepsModule,
		TabMenuModule,
		TabViewModule,
		TerminalModule,
		TieredMenuModule,
		ToggleButtonModule,
		ToolbarModule,
		TooltipModule,
		TreeModule,
		TreeTableModule
	],
	declarations: [
		AppComponent,
		AppMenuComponent,
		AppSubMenu,
		AppTopBar,
		AppFooter,
		InlineProfileComponent,

		/* VietPower Component */
		DashboardComponent,
		SaleComponent,
		OrderComponent,
		WarehouseComponent,
		AccountComponent,
		CategoryComponent,
		CustomerComponent,
		CustomerPaidComponent,
		ExportComponent,
		ImportComponent,
		ProductComponent,
		ReportCustomerPaidComponent,
		ReportExportComponent,
		ReportImportComponent,
		ReportProfitComponent,
		ReportProfitComponent,
		ReportRecentComponent,
		ReportSaleComponent,
		ReportShippingComponent,
		ShippingComponent,
		WarehouseCardComponent
	],
	providers: [
		{ provide: LocationStrategy, useClass: HashLocationStrategy },
		/* VietPower Service */
		HttpService,
		AuthService
	],
	bootstrap: [AppComponent]
})
export class AppModule {
}
