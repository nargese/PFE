import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app.routing';
import { ComponentsModule } from './components/components.module';
import { AppComponent } from './app.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { CommonModule } from '@angular/common';
import { JwtModule } from '@auth0/angular-jwt';
import { LoginComponent } from './login/login.component';
import { ComponentNameComponent } from './component-name/component-name.component';
import { BrowserModule } from '@angular/platform-browser';
import { LocationStrategy, PathLocationStrategy } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { userComponent } from './user/user.component';
import { AuthGuard } from './guards/auth.guard';
import {NgxPaginationModule} from 'ngx-pagination';
import { FilialeComponentComponent } from './filiale-component/filiale-component.component';
import { AddOrEditFilialeComponent } from './filiale-component/add-or-edit-filiale/add-or-edit-filiale.component';
import { ListFilialeComponent } from './filiale-component/list-filiale/list-filiale.component';

export function tokenGetter() {
  return localStorage.getItem("jwt");
}

@NgModule({
  imports: [
    NgxPaginationModule ,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ComponentsModule,
    RouterModule
    .forRoot([
      { path:'',component: DashboardComponent},
      { path:'login',component: LoginComponent},
      { path:'user',component: userComponent, canActivate:[AuthGuard]}
    ]),
    JwtModule.forRoot({
      config:{
        tokenGetter: tokenGetter,
        allowedDomains:["localhost:44323"],
        disallowedRoutes:[]
      }
    }),
    BrowserModule,
    AppRoutingModule,
    CommonModule
  ],
  declarations: [
    AppComponent,
    AdminLayoutComponent,
    ComponentNameComponent,
    FilialeComponentComponent,
    AddOrEditFilialeComponent,
    ListFilialeComponent,

  ],
  providers: [
    { provide: LocationStrategy, useClass: PathLocationStrategy }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
