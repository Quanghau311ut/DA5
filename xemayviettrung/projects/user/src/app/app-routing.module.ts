import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeUserComponent } from './home-user/home-user.component';
import { ListProductsUserComponent } from './list-products-user/list-products-user.component';
import { DetailsProductUserComponent } from './details-product-user/details-product-user.component';

const routes: Routes = [
  {path: '', component:HomeUserComponent},
  {path: 'list-products', component:ListProductsUserComponent},
  {path: 'detail-products', component:DetailsProductUserComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
