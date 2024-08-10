package classe;

public class ValorVsReferencia {

	public static void main(String[] args) {
		
		double a = 2;
		double b = a; // atribuição por valor (Tipo Primitivo)

		a++;
		b--;
		
		System.out.println(a + " " + b);
		
		Data data1 = new Data(1, 6, 2022);
		Data data2 = data1; // Atribuição por Refêrencia (Objetio)
		
		data1._dia = 31;
		data2._mes = 12;
		
		data1._ano = 2025;
		
		System.out.println(data1.obterDataFormatada());
		System.out.println(data2.obterDataFormatada());
		
		voltarDataParaValorPadra(data1);
		
		System.out.println(data1.obterDataFormatada());
		System.out.println(data2.obterDataFormatada());
		
		int c = 5;
		alterarPrimitivo(c);
		System.out.println(c);
	}
	
	static void voltarDataParaValorPadra(Data data) {
		data._dia = 1;
		data._mes = 1;
		data._ano = 1970;
	}
	
	static void alterarPrimitivo(int a) {
		a++;
	}
	

	
}
