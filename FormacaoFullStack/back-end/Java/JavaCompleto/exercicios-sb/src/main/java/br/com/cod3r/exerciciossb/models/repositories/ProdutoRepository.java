package br.com.cod3r.exerciciossb.models.repositories;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import br.com.cod3r.exerciciossb.models.entities.Produto;

public interface ProdutoRepository
	extends CrudRepository<Produto, Integer> {
	
/*
 * findByNomeContaining
 
	findByNomeIsContaining
	findByNomeContains
	
	findByNomeStartsWith
	findByNomeEndsWith
	
	findByNomeNotContaining
*/
	@Query("SELECT p FROM Produto p WHERE p.nome LIKE %:nome%")
	public Iterable<Produto> searchByNameLike(@Param("nome") String nome);
	
	// public Iterable<Produto> findByNomeContainingIgnoreCase(String parteNome);

}
