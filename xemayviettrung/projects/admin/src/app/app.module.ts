import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { EditorModule } from 'primeng/editor';
import { CheckboxModule } from 'primeng/checkbox';
import { FormsModule } from '@angular/forms';
import { NgxPaginationModule } from 'ngx-pagination';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeAdminComponent } from './home-admin/home-admin.component';
import { FooterAdminComponent } from './footer-admin/footer-admin.component';
import { TopbarAdminComponent } from './topbar-admin/topbar-admin.component';
import { SidebarAdminComponent } from './sidebar-admin/sidebar-admin.component';
import { LoginAdminComponent } from './login-admin/login-admin.component';
import { MenusAdminComponent } from './menus-admin/menus-admin.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeAdminComponent,
    FooterAdminComponent,
    TopbarAdminComponent,
    SidebarAdminComponent,
    LoginAdminComponent,
    MenusAdminComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    EditorModule,
    FormsModule,
    CheckboxModule,
    NgxPaginationModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
