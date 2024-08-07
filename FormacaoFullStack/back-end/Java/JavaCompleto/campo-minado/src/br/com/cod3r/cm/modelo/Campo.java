package br.com.cod3r.cm.modelo;

public class Campo {
	
	private final linha;
	private final coluna;
	private boolean minado;
	
	Campo(int linha, int coluna) {
		this.coluna = coluna;
		this.linha = linha; 
		
	}

}
