import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BlogsComponent } from './blogs/blogs.component';
import { ContactsComponent } from './contacts/contacts.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { CartComponent } from './cart/cart.component';
import { ListProductsComponent } from './list-products/list-products.component';
import { DetailBlogsComponent } from './detail-blogs/detail-blogs.component';
import { DetailProductsComponent } from './detail-products/detail-products.component';

@NgModule({
  declarations: [
    AppComponent,
      HomeComponent,
      BlogsComponent,
      ContactsComponent,
      CheckoutComponent,
      CartComponent,
      ListProductsComponent,
      DetailBlogsComponent,
      DetailProductsComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
