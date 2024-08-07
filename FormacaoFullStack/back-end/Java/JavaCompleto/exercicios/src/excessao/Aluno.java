package excessao;

import java.util.ArrayList;

public class Aluno {

	public String nome;
	public double nota;
	final ArrayList<Curso> cursos = new ArrayList<>();
	

	public Aluno(String nome, double nota) {
		this.nome = nome;
	
	}
	
	void adicionarCurso(Curso curso) {
		this.cursos.add(curso);
		curso.alunos.add(this);		
	}
	
	Curso obterCursoPorNome(String nome) {
		Curso procurado = null;
		
		for(Curso curso: this.cursos) {
			if(curso.nome.equalsIgnoreCase(nome)) {
				return curso;
			}
		}
		
		return procurado;
	}
	
	public String toString(String nome)  {
		return "O meu nome é " + nome;
	}
}
