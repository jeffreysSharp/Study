package classe;

public class Data {
	
	int _dia;
	int _mes;
	int _ano;
	
	Data() {
		// _dia = 1;
		// _mes = 1;
		// _ano = 1970;
		this(1, 1, 1970);
		
	}
	
	Data(int _dia, int _mes, int _ano) {
		this._dia = _dia;
		this._mes = _mes;
		this._ano = _ano;
	}
	
	String obterDataFormatada() {		
		return String.format("%d/%d/%d", this._dia,  _mes, _ano); 
	}
	
	void imprimirDataFormatada() {
		System.out.println(obterDataFormatada());
	}
	
}
