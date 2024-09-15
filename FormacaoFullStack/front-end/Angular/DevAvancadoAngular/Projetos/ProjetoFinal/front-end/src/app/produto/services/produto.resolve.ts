import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve } from '@angular/router';
import { IProduto } from '../models/produto.interface';
import { ProdutoService } from './produto.service';

@Injectable()
export class ProdutoResolve implements Resolve<IProduto> {

  constructor(private produtoService: ProdutoService) { }

  resolve(route: ActivatedRouteSnapshot) {
    return this.produtoService.obterPorId(route.params['id']);
  }
}
