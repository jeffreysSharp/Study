import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Usuario } from '../../../models/usuario.model';
import { CommonModule } from '@angular/common';
import { utilsBr } from 'js-brasil';
import { CustomValidators } from 'ng2-validation';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.scss'
})
export class CadastroComponent implements OnInit {

  cadastroForm: FormGroup | any;
  usuario: Usuario | any;
  formResult: string = ' ';
  MASKS = utilsBr.MASKS;

  constructor(private fb: FormBuilder) {
    
  }

  ngOnInit(): void {  

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15])]);
    let confirmeSenha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15]), CustomValidators.equal(senha)]);


    this.cadastroForm = this.fb.group({
      nome: ['', Validators.required,
        Validators.minLength(4)],
      cpf: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      senha: senha,
      confirmeSenha: confirmeSenha
    });
  }

  adicionarUsuario() {
    if(this.cadastroForm.dirty && this.cadastroForm.valid) {
      this.usuario = Object.assign({}, this.usuario, this.cadastroForm);      
      this.formResult = JSON.stringify(this.cadastroForm.value);
    }
    else {
      this.formResult = "Não submeteu!";
    }    
  }

}
