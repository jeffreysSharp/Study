import { NgModule, Provider } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { NgBrazil, TextMask } from 'ng-brazil';
import { CustomFormsModule } from 'ng2-validation';

import { AppComponent } from './app.component';
import { CadastroComponent } from './demos/reactiveForms/cadastro/cadastro.component';
import { SobreComponent } from './institucional/sobre/sobre.component';
import { NavegacaoModule } from './navegacao/navegacao.module';

import { AppRoutingModule } from './app.routes';
import { AuthGuard } from './services/app.guard';
import { CadastroGuard } from './services/cadastro.guard';

import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
import { BarModule } from './demos/bar-di-zones/bar.module';
import { BarServices } from './demos/bar-di-zones/bar.service';
import { FileSizePipe } from './demos/pipes/filmes/filesize.pipe';
import { ImageFormaterPipe } from './demos/pipes/filmes/image.pipe';
registerLocaleData(localePt);

export const BAR_PROVIDERS: Provider[] = [
  BarServices
];

@NgModule({
  declarations: [
    AppComponent,
    SobreComponent,
    CadastroComponent,
    FileSizePipe,
    ImageFormaterPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    NavegacaoModule,
    TextMask.TextMaskModule,
    NgBrazil,
    CustomFormsModule,
    AppRoutingModule,
    BarModule
  ],
  providers: [
    AuthGuard,
    CadastroGuard,
    // BAR_PROVIDERS
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
