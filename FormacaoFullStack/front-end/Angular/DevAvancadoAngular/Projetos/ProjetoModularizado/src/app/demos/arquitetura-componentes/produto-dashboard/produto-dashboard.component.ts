import { AfterViewInit, Component, ElementRef, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { fromEvent, Observable } from 'rxjs';
import { ProdutoDetalheComponent } from '../components/produto-card-detalhe.component';
import { ProdutoCountComponent } from '../components/produto-count.component';
import { Produto } from '../models/produto';

@Component({
  selector: 'app-produto-dashboard',
  templateUrl: './produto-dashboard.component.html'
})

export class ProdutoDashboardComponent implements OnInit, AfterViewInit {

  produtos: Produto[];

  @ViewChild(ProdutoCountComponent, { static: false }) contador: ProdutoCountComponent;
  @ViewChild('token', { static: false }) mensagemTela: ElementRef;

  @ViewChildren(ProdutoDetalheComponent) botoes: QueryList<ProdutoDetalheComponent>;

  constructor(private route: ActivatedRoute) { }


  ngOnInit() {
    this.produtos = this.route.snapshot.data['produtos'];
    console.log(this.route.snapshot.data['teste']);
  }

  ngAfterViewInit(): void {

    console.log('Objeto do contador', this.contador.produtos);

    let clickTexto: Observable<any> = fromEvent(this.mensagemTela.nativeElement, 'click');
    clickTexto.subscribe(() => {
      alert('Clicou no texto');
      return;
    });

    console.log(this.botoes);
    this.botoes.forEach(element => {
      console.log(element.produto);
    });
  }

  mudarStatus(event: Produto) {
    event.ativo = !event.ativo;
  }

}
