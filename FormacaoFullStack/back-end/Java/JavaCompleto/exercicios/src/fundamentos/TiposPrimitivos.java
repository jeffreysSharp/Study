package fundamentos;

public class TiposPrimitivos {

	public static void main(String[] args) {
		// Infirmações do funcionário
		
		//  Tipos numéricos inteiros
		byte anosDeEmpresa  = 23;
		short numeroDeVoos = 542;
		int id = 56789;
		long pontosAcumulados = 3_134_845_233L;
		
		// Tipos numéricos reais
		float salario = 11_445.44F;
		double vendasAcumuladas = 2_991_297_103.01;
		
		// Tipo booleano
		boolean estaDeFerias = false; // true
		
		// Tipo caractere
		char status = 'A'; // Ativo
		
		// Dias de empresa
		System.out.println("O funcionário tem " + anosDeEmpresa * 365 + " dias de empresa");
		
		// Número de viagens
		System.out.println("O Funcionário tem " + numeroDeVoos /2 + " viagens");
		
		// Pontos por real
		System.out.println("O funcionário tem " + pontosAcumulados / vendasAcumuladas + " Pontos Acumulados");
	    System.out.println(id + " Ganha um salário de R$ " + salario);
	    System.out.println("Férias: " + estaDeFerias);
	    System.out.println("Status: " + status);
		
		

	}

}
