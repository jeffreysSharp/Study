package classe;

public class ProdutoTeste {

	public static void main(String[] args) {
	
		Produto produto1 = new Produto("Notebook", 4356.89);		
		
		Produto produto2 = new Produto();
		produto2.nome = "Caneta Preta";
		produto2.preco = 12.56;
		
		Produto.desconto = 0.50;
		
		System.out.println(produto1.nome + " " + produto1.precoComDesconto());
		System.out.println(produto2.nome + " " + produto2.precoComDesconto());

		double precoFinal1 = produto1.precoComDesconto();		
		double precoFinal2 = produto2.precoComDesconto(0.1);
		double mediaCarrinho = (precoFinal1 + precoFinal2) / 2;

		System.out.printf("MédiaCarrinho = R$%.2f. ", mediaCarrinho);
	}

}
