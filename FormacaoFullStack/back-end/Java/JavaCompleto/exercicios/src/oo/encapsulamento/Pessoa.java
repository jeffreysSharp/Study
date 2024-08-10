package oo.encapsulamento;

public class Pessoa {
	
	private int idade;
	private String nome;
	private String sobreNome;
	
	public Pessoa(int idade, String sobrenome, String nome) {
		setNome(nome);
		setSobreNome(sobreNome);
		setIdade(idade);
	}	
	
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getSobreNome() {
		return sobreNome;
	}

	public void setSobreNome(String sobreNome) {
		this.sobreNome = sobreNome;
	}
	
	public String getNomeCompleto() {
		return getNome() + " " + getSobreNome();
	}

	// Getter
	public int getIdade() {
		return idade;
	}	
	
	// Setter
	public void setIdade(int novaIdade) {
		novaIdade = Math.abs(novaIdade);
		if(novaIdade >= 0 && novaIdade <= 120) {
			this.idade = novaIdade;
		}
	}
	
	@Override
	public String toString() {
		return "Olá, eu sou o " + getNome()
		+ " tenho " + getIdade() + " anos.";
	}
}
