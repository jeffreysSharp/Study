package classe;

public class DataTeste {
	
	public static void main(String[] args) {

		Data data1 = new Data();
		data1.dia = 7;
		data1.mes = 11;
		data1.ano = 2021;
		
		System.out.printf("%d/%d/%d\n", data1.dia, data1.mes, data1.ano);
		
		// Verificar var não funciona
		// var data2 = new Data();
		Data data2 = new Data();
		data2.dia = 31;
		data2.mes = 12;
		data2.ano = 2020;
		
		System.out.printf("%d/%d/%d\n", data2.dia, data2.mes, data2.ano);
	}
}
