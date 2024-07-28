package fundamentos;

public class Termperatura {

	public static void main(String[] args) {
		// ( °F - 32 ) x 5/9 = °C
		
		// CONST
		final double FATOR = 5.0 / 9.0;
		final double AJUSTE = 32;
		
		double fharenheit = 86;
		double celsius = (fharenheit - AJUSTE) * FATOR;
		
		fharenheit = 150;
		celsius = (fharenheit - AJUSTE) * FATOR;
		
		System.out.println("O Resultado é: " + celsius + "°C.");
	
	}

}
