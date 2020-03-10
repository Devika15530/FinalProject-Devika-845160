import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BuyerComponent } from './Buyer/buyer/buyer.component';
import { SearchComponent } from './Buyer/search/search.component';
import { ViewCartComponent } from './Buyer/viewcart/view-cart.component';
import { PurchaseHistoryComponent } from './Buyer/purchasehistory/purchase-history.component';
import { BuyProductComponent } from './Buyer/buyproduct/buy-product.component';
import { SellerComponent } from './Seller/seller/seller.component';
import { AddItemsComponent } from './Seller/add-items/add-items.component';
import { ViewItemsComponent } from './Seller/view-items/view-items.component';
import { ViewReportsComponent } from './Seller/view-reports/view-reports.component';
import { AdminComponent } from './Admin/admin/admin.component';
import { BlockUnblockBuyerComponent } from './Admin/block-unblock-buyer/block-unblock-buyer.component';
import { BlockUnblockSellerComponent } from './Admin/block-unblock-seller/block-unblock-seller.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddSubCategoryComponent } from './Admin/add-sub-category/add-sub-category.component';
import { DailyreportsComponent } from './Admin/dailyreports/dailyreports.component';
import { LoginComponent } from './Account/login/login.component';

import { RegisterSellerComponent } from './Account/register-seller/register-seller.component';
import { ViewbuyerprofileComponent } from './Buyer/viewbuyerprofile/viewbuyerprofile.component';
import { ViewsellerprofileComponent } from './Seller/viewsellerprofile/viewsellerprofile.component';
import { HomeComponent } from './Account/home/home.component';
import { RegisterBuyerComponent } from './Account/register-buyer/register-buyer.component';

import { ViewsubcategoriesComponent } from './Admin/viewsubcategories/viewsubcategories.component';
import { LogoutComponent } from './logout/logout.component';



const routes: Routes = [
  {path:'buyer',component:BuyerComponent,children:
  [{path:'search',component:SearchComponent},
 { path:'view-cart',component:ViewCartComponent},
 { path:'purchasehistory',component:PurchaseHistoryComponent},
 { path:'buy-product',component:BuyProductComponent},
 { path:'viewbuyerprofile',component:ViewbuyerprofileComponent},
]},

{path:'seller',component:SellerComponent,children:
[
  {path:'add-items',component:AddItemsComponent},
  {path:'view-items',component:ViewItemsComponent},
  {path:'viewsellerprofile',component:ViewsellerprofileComponent},
  {path:'view-reports',component:ViewReportsComponent},


]},


{path:'admin',component:AdminComponent,children:
[
  {path:'block-unblock-buyer',component:BlockUnblockBuyerComponent},
  {path:'block-unblock-seller',component:BlockUnblockSellerComponent},
  {path:'add-category',component:AddCategoryComponent},
  {path:'add-sub-category',component:AddSubCategoryComponent},
  {path:'dailyreports',component:DailyreportsComponent},

 
  {path:'viewsubcategories',component:ViewsubcategoriesComponent}
]},


{path:'home',component:HomeComponent,children:
[
{path:'login',component:LoginComponent},

{path:'register-buyer',component:RegisterBuyerComponent},
{path:'register-seller',component:RegisterSellerComponent},

]},


{path:'logout',component:LogoutComponent},

{path:'',component:HomeComponent}
];




@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
