import { Injectable } from "@angular/core";

@Injectable()
export class BarServices {

    constructor() { }

    obterBebidas(): string {
        return 'Bebidas';
    }

    obterPorcoes(): string {
        return 'Porções';
    }

    obterRefeicoes(): string {
        return 'Refeições';
    }
}