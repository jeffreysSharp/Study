package fundamentos;

public class Temperatura {

	public static void main(String[] args) {
		// (°F - 32) x 5/9 = °C
		final double FATOR = 5.0 / 9.0;
		final double AJUSTE = 32;

		double fharenheit = 86;
		double celsius = (fharenheit - AJUSTE) * FATOR;
		System.out.println("O resultado é " + celsius + "°C");

		fharenheit = 0;
		celsius = (fharenheit - AJUSTE) * FATOR;
		System.out.println("O resultado é " + celsius + "°C");
	}

}
