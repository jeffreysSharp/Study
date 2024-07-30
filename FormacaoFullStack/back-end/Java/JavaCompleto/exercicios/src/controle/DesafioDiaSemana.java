package controle;

import java.util.Scanner;

public class DesafioDiaSemana {

	public static void main(String[] args) {


		
		System.out.print("Digite o dia da semana: ");
		Scanner entrada = new Scanner(System.in);
		int dia = entrada.nextInt();
		
		if(dia == 1) {
			System.out.println("Hoje é domingo");
		} else if(dia == 2) {
			System.out.println("Hoje é segunda-feira");
		} else if(dia == 3) {
			System.out.println("Hoje é terça-feira");
		}else if(dia == 4) {
			System.out.println("Hoje é quarta-feira");
		}else if(dia == 5) {
			System.out.println("Hoje é quinta-feira");
		}else if(dia == 6) {
			System.out.println("Hoje é sextaa-feira");
		}else if(dia == 7) {
			System.out.println("Hoje é sábado");
		}
		
			
		
		
		entrada.close();
		
		

	}

}
