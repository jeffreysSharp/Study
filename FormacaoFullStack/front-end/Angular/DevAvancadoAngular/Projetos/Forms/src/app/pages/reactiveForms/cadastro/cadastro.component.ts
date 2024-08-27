import { AfterViewInit, Component, ElementRef, OnInit, ViewChildren } from '@angular/core';
import { FormBuilder, FormControl, FormControlName, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Usuario } from '../../../models/usuario.model';
import { CommonModule } from '@angular/common';
import { utilsBr } from 'js-brasil';
import { CustomValidators } from 'ng2-validation';
import { DisplayMessage, GenericValidator, ValidationMessages } from './generic-form-validation';
import { fromEvent, merge, Observable } from 'rxjs';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.scss'
})
export class CadastroComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[] | any;

  cadastroForm: FormGroup | any;
  usuario: Usuario | any;
  formResult: string = ' ';
  MASKS = utilsBr.MASKS;

  validationMessages: ValidationMessages | any;
  genericValidator: GenericValidator | any;
  displayMessage: DisplayMessage = {};

  constructor(private fb: FormBuilder) {
    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido!',
        minlength: 'O Nome precisa ter no mínimo 2 caracteres!',
        maxlength: 'O Nome precisa ter no máximo 150 caracteres'
      },
      cpf: {
        required: 'Informe o CPF!',
        cpf: 'CPF em formato inválido!'
      }, 
      email: {
        required: 'Informe o E-mail!',
        email: 'E-mail inválido!'
      },
      senha: {
        required: 'Informe a Senha',
        rangeLength: 'A Senha deve possuir entre 6 e 15 caracteres'
      },
      confirmeSenha: {
        required: 'Informe a Senha novamente',
        rangeLength: 'A Senha deve possuir entre 6 e 15 caracteres',
        equalTo: 'As Senhas não conferem'
      }
    };

    this.genericValidator = new GenericValidator(this.validationMessages);

  }

  ngOnInit(): void {  

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15])]);
    let confirmeSenha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15]), CustomValidators.equal(senha)]);


    this.cadastroForm = this.fb.group({
      nome: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(150)]],
      cpf: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      senha: senha,
      confirmeSenha: confirmeSenha
    });
  }

  ngAfterViewInit(): void {
    let controlBlurs: Observable<any>[] = this.formInputElements
    .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(() => {
      this.displayMessage = this.genericValidator.processarMensagens(this.cadastroForm);
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
