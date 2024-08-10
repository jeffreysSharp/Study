package fundamentos.operadores;

public class Relacionais {

	public static void main(String[] args) {
		
		
		int a = 97;		
		int b = 'a';
		
		System.out.println(a == b);	// true	
		System.out.println(30 != 7); //true
		System.out.println(3 > 4); // false
		System.out.println(3 >= 3); // true
		System.out.println(3 < 7); // true
		System.out.println(30 <=7); // false
		
		double nota = 9.0;
		boolean bomComportamento = false;
		boolean passouPorMedia = nota >- 7;
		boolean temDesconto = bomComportamento && passouPorMedia;
		
		System.out.println("Tem desconto? " + temDesconto); // false
		
		
	}

}
