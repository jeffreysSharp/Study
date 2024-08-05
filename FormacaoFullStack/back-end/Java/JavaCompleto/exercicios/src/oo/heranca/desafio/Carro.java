package oo.heranca.desafio;

class Carro {

	public final int VELOCIDADE_MAXIMA;
	protected int velocidadeAtual;
	protected int delta = 5;	
	
	protected Carro(int velocidadeMaxima) {
		VELOCIDADE_MAXIMA = velocidadeMaxima;		
	}
	
	public void acelerar() {
		if(velocidadeAtual + 5 > VELOCIDADE_MAXIMA) {
			velocidadeAtual += 5;	
		} else {
			velocidadeAtual += delta;	
		}
					
	}
	
	public void frear() {
		if(velocidadeAtual >= 5) {
			velocidadeAtual -= 5; 
		} else {
			velocidadeAtual = 0;
		}
		velocidadeAtual -= 5;
	}
	
	public String toString() {
		return "Velocidade atual é " + velocidadeAtual + "Km/h";
	}
	
}
