import { NgModule } from '@angular/core';
import { CommonModule, } from '@angular/common';
import { BrowserModule  } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';

import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';

import {LoginComponent } from './login/login.component';
import { User } from '../app/Model/user';
import { FilialeComponentComponent } from './filiale-component/filiale-component.component';
import { ListFilialeComponent } from './filiale-component/list-filiale/list-filiale.component';
import { AddOrEditFilialeComponent } from './filiale-component/add-or-edit-filiale/add-or-edit-filiale.component';
// import { AuthService } from '../app/Service/auth.service';


const routes: Routes =[
  {
    path: 'login',
    redirectTo: 'login',
    pathMatch: 'full',
  }, {
    path: '',
    component: AdminLayoutComponent,
    children: [{
      path: '',
      loadChildren: () => import('./layouts/admin-layout/admin-layout.module').then(m => m.AdminLayoutModule)
    }]
  },{
    path: 'login', 
    component: LoginComponent,
  },
  {
    path: 'Filiale', 
    component: FilialeComponentComponent,
  },
  {
    path: 'ListeFiliale', 
    component: ListFilialeComponent,
  },{
    path: 'AddOrEditFiliale', 
    component: AddOrEditFilialeComponent,
  },

];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes,{
       useHash: true
    })
  ],
  exports: [RouterModule
  ],
})
export class AppRoutingModule { }

