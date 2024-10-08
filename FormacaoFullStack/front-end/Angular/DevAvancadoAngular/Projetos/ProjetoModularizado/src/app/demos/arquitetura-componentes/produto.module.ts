import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
registerLocaleData(localePt);

import { FilmesComponent } from '../pipes/filmes/filmes.component';
import { ProdutoDetalheComponent } from './components/produto-card-detalhe.component';
import { ProdutoCountComponent } from './components/produto-count.component';
import { EditarProdutoComponent } from './editar-produto/editar-produto.component';
import { ProdutoDashboardComponent } from './produto-dashboard/produto-dashboard.component';
import { ProdutoAppComponent } from './produto.app.component';
import { ProdutoRoutingModule } from './produto.route';
import { ProdutoResolve } from './services/produto.resolve';
import { ProdutoService } from './services/produto.service';

@NgModule({
    declarations: [
        ProdutoAppComponent,
        ProdutoDashboardComponent,
        ProdutoDetalheComponent,
        ProdutoCountComponent,
        EditarProdutoComponent,
        FilmesComponent
    ],
    imports: [
        CommonModule,
        ProdutoRoutingModule
    ],
    exports: [],
    providers: [
        ProdutoService,
        ProdutoResolve
    ]
})
export class ProdutoModule { }