using NerdStore.Catalogo.Domain;
using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.DomainTests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            // Arrange & Act Assert

            var ex = Assert.Throws<DomainException>(() =>
                new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
                );

            Assert.Equal("O campo Nome do Produto n�o pode estar vazio", ex.Message);


            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Descri��o do Produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
            new Produto("Nome", "Descricao", false, 0, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Valor n�o pode ser menor ou igual a zero", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
            new Produto("Nome", "Descricao", false, 100, Guid.Empty, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo CategoriaId do produto n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
            new Produto("Nome", "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo imagem do Produto n�o pode estar vazio", ex.Message);
        }
    }
}