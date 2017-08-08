import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

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

export const routes: Routes = [
	/* VietPower Route */
	{ path: '', component: DashboardComponent },
	{ path: 'sale', component: SaleComponent },
	{ path: 'order', component: OrderComponent },
	{ path: 'warehouse', component: WarehouseComponent },
	{ path: 'import', component: ImportComponent },
	{ path: 'export', component: ExportComponent },
	{ path: 'product', component: ProductComponent },
	{ path: 'account', component: AccountComponent },
	{ path: 'category', component: CategoryComponent },
	{ path: 'customer', component: CustomerComponent },
	{ path: 'customer-paid', component: CustomerPaidComponent },
	{ path: 'warehouse-card', component: WarehouseCardComponent },
	{ path: 'report-customer-paid', component: ReportCustomerPaidComponent },
	{ path: 'report-import', component: ReportImportComponent },
	{ path: 'report-export', component: ReportExportComponent },
	{ path: 'report-profit', component: ReportProfitComponent },
	{ path: 'report-recent', component: ReportRecentComponent },
	{ path: 'report-sale', component: ReportSaleComponent },
	{ path: 'report-shipping', component: ReportShippingComponent },
	{ path: 'shipping', component: ShippingComponent }
];

export const AppRoutes: ModuleWithProviders = RouterModule.forRoot(routes);
