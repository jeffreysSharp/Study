using NerdStore.Core;
using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class Produto : Entity, IAgregateRoot
    {
        public Guid CategoriaId { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public Categoria Categoria { get; set; }

        public Produto(string nome, string descricao, bool ativo, decimal valor, Guid categoriad, DateTime dataCadastro, string imagem)
        {
            CategoriaId = categoriad;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;

            Validar();
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;

        }

        public void AlterarDescricao(string descricao)
        {
            Validacoes.ValidarSeVazio(descricao, "O campo Descrição do Produto não pode estar vazio");
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PussuiEstoque(quantidade)) throw new DomainException("Estoque insufuciente");
            QuantidadeEstoque -= quantidade;

        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public bool PussuiEstoque(int quantidade)
        { 
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo nome do Produto não pode estar vazio");
            Validacoes.ValidarSeVazio(Descricao, "O campo Descrição do Produto não pode estar vazio");
            Validacoes.ValidarSeDiferente(CategoriaId, Guid.Empty, "O campo Categoria do Produto não pode estar vazio");
            Validacoes.ValidarSeMenorIgualMinimo(Valor, 0, "O campo Imagem do Produto não pode estar vazio");
            Validacoes.ValidarSeVazio(Imagem, "O campo imagem do Produto não pode estar vazio");

        }
    }
}
