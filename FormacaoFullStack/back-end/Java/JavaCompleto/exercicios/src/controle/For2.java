package controle;

import java.util.Scanner;

public class For2 {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);

		for(int contador = 10; contador >= 0; contador -= 2) {
			System.out.printf("Contador = %d\n", contador);
		}

		entrada.close();

	}

}
