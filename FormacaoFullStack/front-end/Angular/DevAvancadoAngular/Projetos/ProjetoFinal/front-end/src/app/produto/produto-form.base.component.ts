import { FormGroup } from '@angular/forms';

import { utilsBr } from 'js-brasil';

import { ElementRef } from '@angular/core';
import { FormBaseComponent } from '../base-components/form-base.component';
import { IFornecedor } from './models/fornecedor.interface';
import { IProduto } from './models/produto.interface';

export abstract class ProdutoBaseComponent extends FormBaseComponent {

  produto: IProduto;
  fornecedores: IFornecedor[];
  errors: any[] = [];
  produtoForm: FormGroup;

  MASKS = utilsBr.MASKS;

  constructor() {
    super();

    this.validationMessages = {
      fornecedorId: {
        required: 'Escolha um fornecedor',
      },
      nome: {
        required: 'Informe o Nome',
        minlength: 'Mínimo de 2 caracteres',
        maxlength: 'Máximo de 200 caracteres'
      },
      descricao: {
        required: 'Informe a Descrição',
        minlength: 'Mínimo de 2 caracteres',
        maxlength: 'Máximo de 1000 caracteres'
      },
      imagem: {
        required: 'Informe a Imagem',
      },
      valor: {
        required: 'Informe o Valor',
      }
    }

    super.configurarMensagensValidacaoBase(this.validationMessages);
  }

  protected configurarValidacaoFormulario(formInputElements: ElementRef[]) {
    super.configurarValidacaoFormularioBase(formInputElements, this.produtoForm);
  }
}
