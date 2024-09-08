import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CustomFormsModule } from 'ngx-custom-validators';

import { CadastroComponent } from './cadastro/cadastro.component';
import { ContaAppComponent } from './conta.app.component';
import { ContaRoutingModule } from './conta.route';
import { LoginComponent } from './login/login.component';

import { ContaGuard } from './services/conta.guard';
import { ContaService } from './services/conta.service';



@NgModule({
  declarations: [
    ContaAppComponent,
    CadastroComponent,
    LoginComponent
  ],
  imports: [
    CommonModule,
    ContaRoutingModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    CustomFormsModule
  ],
  providers: [
    ContaService,
    ContaGuard
  ]
})
export class ContaModule { }
