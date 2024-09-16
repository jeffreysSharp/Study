import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { IProduto } from '../models/produto.interface';

@Component({
  selector: 'app-detalhes',
  templateUrl: './detalhes.component.html'
})
export class DetalhesComponent {

  imagens: string = environment.imagensUrl;
  produto: IProduto;

  constructor(private route: ActivatedRoute) {

    this.produto = this.route.snapshot.data['produto'];
  }

}
