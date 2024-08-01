package classe;

public class Data {
	
	int _dia;
	int _mes;
	int _ano;
	
	Data() {
		_dia = 1;
		_mes = 1;
		_ano = 1970;
	}
	
	Data(int dia, int mes, int ano) {
		_dia = dia;
		_mes = mes;
		_ano = ano;
	}
	
	String obterDataFormatada() {		
		return String.format("%d/%d/%d", _dia,  _mes, _ano); 
	}
	
	void imprimirDataFormatada() {
		System.out.println(obterDataFormatada());
	}
	
}
