package oo.heranca.desafio;

public class Carro {

	final int VELOCIDADE_MAXIMA;
	int velocidadeAtual;
	 int delta = 5;
	
	Carro(int velocidadeMaxima) {
		VELOCIDADE_MAXIMA = velocidadeMaxima;		
	}
	
	void acelerar() {
		if(velocidadeAtual + 5 > VELOCIDADE_MAXIMA) {
			velocidadeAtual += 5;	
		} else {
			velocidadeAtual += delta;	
		}
					
	}
	
	void frear() {
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
