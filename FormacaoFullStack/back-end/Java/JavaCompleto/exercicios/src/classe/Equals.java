package classe;


public class Equals {

	public static void main(String[] args) {
	
		Usuario usuario1 = new Usuario();
		usuario1.nome = "Pedro Silva";
		usuario1.email = "pedro@gmail.com";
		
		Usuario usuario2 = new Usuario();
		usuario2.nome = "Pedro Silva";
		usuario2.email = "pedro@gmail.com";
		
		System.out.println(usuario1 == usuario2);
		System.out.println(usuario1.equals(usuario2));
		System.out.println(usuario2.equals(usuario1));
		
		// System.out.println(usuario2.equals(new Date()));
		
	}
	
}
