package fundamentos;

public class TiposPrimitivos {

	public static void main(String[] args) {
		// Infirma��es do funcion�rio
		
		//  Tipos num�ricos inteiros
		byte anosDeEmpresa  = 23;
		short numeroDeVoos = 542;
		int id = 56789;
		long pontosAcumulados = 3_134_845_233L;
		
		// Tipos num�ricos reais
		float salario = 11_445.44F;
		double vendasAcumuladas = 2_991_297_103.01;
		
		// Tipo booleano
		boolean estaDeFerias = false; // true
		
		// Tipo caractere
		char status = 'A'; // Ativo
		
		// Dias de empresa
		System.out.println("O funcion�rio tem " + anosDeEmpresa * 365 + " dias de empresa");
		
		// N�mero de viagens
		System.out.println("O Funcion�rio tem " + numeroDeVoos /2 + " viagens");
		
		// Pontos por real
		System.out.println("O funcion�rio tem " + pontosAcumulados / vendasAcumuladas + " Pontos Acumulados");
	    System.out.println(id + " Ganha um sal�rio de R$ " + salario);
	    System.out.println("F�rias: " + estaDeFerias);
	    System.out.println("Status: " + status);
		
		

	}

}
