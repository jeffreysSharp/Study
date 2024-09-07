import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IUsuario } from "../models/usuario.interface";

@Injectable()
export class ContaService {

  constructor(private http: HttpClient
  ) { }

  registrar(usuario: IUsuario) {

  }

  login(usuario: IUsuario) {

  }

}
