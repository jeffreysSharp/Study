import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

import { Observable } from "rxjs";
import { catchError, map } from "rxjs/operators";

import { Fornecedor } from "src/app/fornecedor/models/fornecedor";
import { BaseService } from 'src/app/services/base.service';
import { IProduto } from "../models/produto.interface";

@Injectable()
export class ProdutoService extends BaseService {

  constructor(private http: HttpClient) { super() }

  obterTodos(): Observable<IProduto[]> {
    return this.http
      .get<IProduto[]>(this.UrlServiceV1 + "produtos", super.ObterAuthHeaderJson())
      .pipe(catchError(super.serviceError));
  }

  obterPorId(id: string): Observable<IProduto> {
    return this.http
      .get<IProduto>(this.UrlServiceV1 + "produtos/" + id, super.ObterAuthHeaderJson())
      .pipe(catchError(super.serviceError));
  }

  novoProduto(produto: IProduto): Observable<IProduto> {
    return this.http
      .post(this.UrlServiceV1 + "produtos", produto, super.ObterAuthHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError));
  }

  atualizarProduto(produto: IProduto): Observable<IProduto> {
    return this.http
      .put(this.UrlServiceV1 + "produtos/" + produto.id, produto, super.ObterAuthHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError));
  }

  excluirProduto(id: string): Observable<IProduto> {
    return this.http
      .delete(this.UrlServiceV1 + "produtos/" + id, super.ObterAuthHeaderJson())
      .pipe(
        map(super.extractData),
        catchError(super.serviceError));
  }

  obterFornecedores(): Observable<Fornecedor[]> {
    return this.http
      .get<Fornecedor[]>(this.UrlServiceV1 + "fornecedores")
      .pipe(catchError(super.serviceError));
  }
}
