import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListProductsComponent } from './list-products/list-products.component';
import { DetailProductsComponent } from './detail-products/detail-products.component';
import { BlogsComponent } from './blogs/blogs.component';
import { DetailBlogsComponent } from './detail-blogs/detail-blogs.component';
import { CartComponent } from './cart/cart.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { ContactsComponent } from './contacts/contacts.component';

const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'list-products', component: ListProductsComponent},
  { path: 'detail-products', component: DetailProductsComponent},
  { path: 'cart', component: CartComponent},
  { path: 'checkout', component: CheckoutComponent},
  { path: 'blogs', component: BlogsComponent},
  { path: 'detail-blogs', component: DetailBlogsComponent},
  { path: 'contacts', component: ContactsComponent},



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
