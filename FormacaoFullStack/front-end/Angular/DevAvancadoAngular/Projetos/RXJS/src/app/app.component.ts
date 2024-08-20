import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  template: `
    <h1>Welcome to {{title}}!</h1>

    <router-outlet />
  `,
  styles: [],
})
export class AppComponent implements OnInit {
  title = 'RXJS';

  ngOnInit(): void {
    
    // this.minhaPromise('Eduardo')
    // .then(result => console.log(result));

    // this.minhaPromise('José')
    // .then(result => console.log(result))
    // .catch(erro => console.log(erro))
      
    // this.minhaPrimeiraObservable('Eduardo')
    // .subscribe(
    //   result => console.log(result),
    //   erro => console.log(erro),
    //   complete: () => console.log('Fim!'));

    //   const observer = {
    //     next: valor => console.log('Next: ', valor),
    //     error: erro => console.log('Erro', erro),
    //     complete: () => console.log('Fim!')
    //   }

    //   const obs = this.minhaPrimeiraObservable('Eduardo');
    //   obs.subscribe(observer);

    // const obs = this.usuarioObservable('Admin', 'admin@admin.com');
    // const subs = obs.subscribe(observer);

    // setTimeout(() => {
    //   subs.unsubscribe();
    //   console.log('Conexão fechada: ', subs.closed)
    // }, 3500);
  }

  minhaPrimeiraObservable(nome: string) : Observable<string> {
    return new Observable(subscriber => {
      if(nome === 'Eduardo') {
        subscriber.next('Olá ' + nome);
        subscriber.next('Olá de novo! ' + nome);
        setTimeout(() => {
        subscriber.next('Resposta com delay!');
        }, 5000);
        subscriber.complete();
      } 
      else {
        subscriber.error('Ops! Deu erro!')
      }
    })
  }

  usuarioObservable(nome: string, email: string) : Observable<Usuario> {
    return new Observable(subscriber => {
      if(nome === 'Admin') {

        let usuario = new Usuario(nome, email);

        setTimeout(() => {
          subscriber.next(usuario);
          }, 1000);

         setTimeout(() => {
            subscriber.next(usuario);
         }, 2000);

         setTimeout(() => {
              subscriber.next(usuario);
         }, 3000);

         setTimeout(() => {
             subscriber.next(usuario);
          }, 4000);

          setTimeout(() => {
              subscriber.complete();
           }, 5000);
      } 
      else {
        subscriber.error('Ops! Deu erro!')
      }
    })
  }
  
  minhaPromise(nome: string) : Promise<string>{
    return new Promise((resolve, reject) => {
      if(nome === 'Eduardo') {
        setTimeout(() => {
          resolve('Seja bem vindo ' + nome);
        }, 5000);
      }
      else {
        reject('Opps! Você não é o Eduardo');
      }
    })
  }
}

export class Usuario {

  nome: string;
  email: string;

  constructor(nome: string, email: string) {
    this.nome = nome;
    this.email = email;
  }
}
