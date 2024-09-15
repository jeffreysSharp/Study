import { IProduto } from 'src/app/produto/models/produto.interface';
import { Endereco } from './endereco';

export class Fornecedor {
  id: string;
  nome: string;
  documento: string;
  ativo: boolean;
  tipoFornecedor: number;
  endereco: Endereco;
  produtos: IProduto[];
}

