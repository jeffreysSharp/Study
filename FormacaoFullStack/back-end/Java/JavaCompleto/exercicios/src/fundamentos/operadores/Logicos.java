package fundamentos.operadores;

public class Logicos {

	public static void main(String[] args) {
		
		boolean condicao1 = true;
		boolean condicao2 = 3 > 7;		
		
		System.out.println(condicao1 && !condicao2); // true
		System.out.println(condicao1 || condicao2); // true
		System.out.println(!!condicao1); // true
		System.out.println(!condicao2); // true
		
		System.out.println("Tabela verdade E (AND)");
		System.out.println(true && true); // true
		System.out.println(true && false); // false		
		// System.out.println(false && true); // false
		// System.out.println(false && false); // false
		
		System.out.println("\nTabela verdade OU (OR)");
		// System.out.println(true || true); // true
		// System.out.println(true || false); // true
		System.out.println(false || true); // true
		System.out.println(false || false); // false
		
		System.out.println("\nTabela verdade OU Exclusivo (XOR)");
		System.out.println(true ^ true); // false
		System.out.println(true ^ false); // true
		System.out.println(false ^ true); // true
		System.out.println(false ^ false); // false
		
		System.out.println("\nTabela verdade NOT");
		System.out.println(!true); // false
		System.out.println(!false); // true
		
		
	}

}
