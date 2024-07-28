package fundamentos.operadores;

public class DesafioLogicos {
	public static void main(String[] args) {
		 // Trabalho na terça ( V ou F )
		 // Trabalho na quinta ( V ou F )
		
		boolean trabalho1 = true;
		boolean trabalho2 = false;
		
		boolean comprouTV50 = trabalho1 && trabalho2;
		boolean comprouTV32 = trabalho1 || trabalho2;
		boolean comprouSorvete = trabalho1 || trabalho2;
		
		// Operador Unário
		boolean maisSaldavel = !comprouSorvete;
		
		System.out.println("Comprou TV50\" ? = " + comprouTV50); // false
		System.out.println("Comprou TV32\" ? = " + comprouTV32); // true
		System.out.println("Comprou TV32\" e Sorvete ? = " + comprouSorvete); // true
		System.out.println("Mais saldável? = " + maisSaldavel); // false
		
		
	}

}
