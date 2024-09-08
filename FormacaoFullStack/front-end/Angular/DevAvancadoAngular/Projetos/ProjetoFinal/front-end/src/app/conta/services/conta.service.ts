import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { catchError, map } from "rxjs/operators";
import { BaseService } from "src/app/services/base.service";
import { IUsuario } from "../models/usuario.interface";

@Injectable()
export class ContaService extends BaseService {

  constructor(private http: HttpClient
  ) { super(); }

  registrar(usuario: IUsuario): Observable<IUsuario> {

    let response = this.http
      .post(this.urlServicev1 + 'nova-conta', usuario, this.obterHeadeerJson())
      .pipe(
        map(this.extractData),
        catchError(this.serviceError));

    return response;

  }

  login(usuario: IUsuario): Observable<IUsuario> {
    let response = this.http
      .post(this.urlServicev1 + 'entrar', usuario, this.obterHeadeerJson())
      .pipe(
        map(this.extractData),
        catchError(this.serviceError));

    return response;
  }

}
