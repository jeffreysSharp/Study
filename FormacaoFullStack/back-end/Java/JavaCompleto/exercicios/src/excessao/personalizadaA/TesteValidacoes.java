package excessao.personalizadaA;

import excessao.Aluno;

public class TesteValidacoes {
	
	public static void main(String[] args) {
		
		try {
			Aluno aluno  = new Aluno("Ana", 7);		
			Validar.aluno(null);
		} catch (StringVaziaException e) {
			System.out.println(e.getMessage());
		} catch (NumeroForaIntervaloException 
				| IllegalArgumentException e) {
			System.out.println(e.getMessage());
		}
		
		System.out.println("Fim :");
	}
}
