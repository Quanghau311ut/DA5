import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeUserComponent } from './home-user/home-user.component';
import { FooterUserComponent } from './footer-user/footer-user.component';
import { HeaderUserComponent } from './header-user/header-user.component';
import { SliderUserComponent } from './slider-user/slider-user.component';
import { ListProductsUserComponent } from './list-products-user/list-products-user.component';
import { DetailsProductUserComponent } from './details-product-user/details-product-user.component';


@NgModule({
  declarations: [
    AppComponent,
      HomeUserComponent,
      FooterUserComponent,
      HeaderUserComponent,
      SliderUserComponent,
      ListProductsUserComponent,
      DetailsProductUserComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
