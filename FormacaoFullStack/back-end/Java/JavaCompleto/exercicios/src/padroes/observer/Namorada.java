package padroes.observer;

public class Namorada implements ObservadorChegadaAniversariante {

	public void chegou(EventoChegadaAniversariante evento) {
	
		System.out.println("Avisar os convidadod...");
		System.out.println("Apagar as luzes...");
		System.out.println("Esperar um pouco...");
		System.out.println("e...Surpresa...");
		
	}
	
}
