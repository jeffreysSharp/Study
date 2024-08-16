package br.com.cod3r.exerciciossb;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

@RestController
public class PrimeiroController {

	@GetMapping(path = { "/ola", "/saudacao" })
	public String ola() {
		return "Olá Spring Boot";
	}
	
	@PostMapping(path = "/saudacao")
	public String saudacao() {
		return "Olá Spring Boot (POST)";
	}
}
