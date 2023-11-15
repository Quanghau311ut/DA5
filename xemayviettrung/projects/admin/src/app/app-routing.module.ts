import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './home-admin/home-admin.component';
import { LoginAdminComponent } from './login-admin/login-admin.component';
import { MenusAdminComponent } from './menus-admin/menus-admin.component';



const routes: Routes = [
  {path: '', component:HomeAdminComponent},
  {path: 'login', component:LoginAdminComponent},
  {path: 'menu', component:MenusAdminComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
