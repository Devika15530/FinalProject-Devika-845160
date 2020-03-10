import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { AddItemsComponent } from './Seller/add-items/add-items.component';
import { ViewItemsComponent } from './Seller/view-items/view-items.component';
import { ViewReportsComponent } from './Seller/view-reports/view-reports.component';
import { SearchComponent } from './Buyer/search/search.component';
import { ViewCartComponent } from './Buyer/viewcart/view-cart.component';
import { PurchaseHistoryComponent } from './Buyer/purchasehistory/purchase-history.component';
import { BuyProductComponent } from './Buyer/buyproduct/buy-product.component';
import { BlockUnblockBuyerComponent } from './Admin/block-unblock-buyer/block-unblock-buyer.component';
import { BlockUnblockSellerComponent } from './Admin/block-unblock-seller/block-unblock-seller.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddSubCategoryComponent } from './Admin/add-sub-category/add-sub-category.component';
import { DailyreportsComponent } from './Admin/dailyreports/dailyreports.component';
import { SellerComponent } from './Seller/seller/seller.component';
import { BuyerComponent } from './Buyer/buyer/buyer.component';
import { AdminComponent } from './Admin/admin/admin.component';
import { LoginComponent } from './Account/login/login.component';
import { RegisterSellerComponent } from './Account/register-seller/register-seller.component';

import { ViewbuyerprofileComponent } from './Buyer/viewbuyerprofile/viewbuyerprofile.component';
import { ViewsellerprofileComponent } from './Seller/viewsellerprofile/viewsellerprofile.component';
import { HomeComponent } from './Account/home/home.component';
import {ReactiveFormsModule, FormsModule} from '@angular/forms';
import { RegisterBuyerComponent } from './Account/register-buyer/register-buyer.component'
import { AccountService } from './Services/account.service';
import { AdminService } from './Services/admin.service';

import { ViewsubcategoriesComponent } from './Admin/viewsubcategories/viewsubcategories.component';
import { LogoutComponent } from './logout/logout.component';
import { ViewcategoriesComponent } from './Admin/viewcategories/viewcategories.component';

@NgModule({
  declarations: [
    AppComponent,
 
    AddItemsComponent,
    ViewItemsComponent,
    ViewReportsComponent,
    SearchComponent,
    ViewCartComponent,
    PurchaseHistoryComponent,
    BuyProductComponent,
    BlockUnblockBuyerComponent,
    BlockUnblockSellerComponent,
    AddCategoryComponent,
    AddSubCategoryComponent,
    DailyreportsComponent,
    SellerComponent,
    BuyerComponent,
    AdminComponent,
    LoginComponent,
    RegisterSellerComponent,
    
    ViewbuyerprofileComponent,
    ViewsellerprofileComponent,
    HomeComponent,
    RegisterBuyerComponent,

    ViewsubcategoriesComponent,
    LogoutComponent,
    ViewcategoriesComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [AccountService,AdminService],
  bootstrap: [AppComponent]
})
export class AppModule { }
