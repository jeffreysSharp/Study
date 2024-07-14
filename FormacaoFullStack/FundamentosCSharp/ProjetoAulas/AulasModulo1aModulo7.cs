/*Console.WriteLine("Primeiro programa");

== Variaveis
int idade = 33;  
Console.WriteLine(idade);        
string nomePessoa = "Rafael Almeida";
Console.WriteLine(nomePessoa);    
decimal valor = 200.99m;
double valorDouble = 200.99;
float valorFloat = 200.99f;
var idadeNova = 34;        
char flag = 'F';     
bool ativo = true;
ativo = false;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);
Console.WriteLine(idadeNova);
Console.WriteLine(flag);
Console.WriteLine(ativo);   
const string descricao = "Curso C#";
Console.WriteLine(descricao);
*/

//var numero1 = 1;
//var numero2 = 2;


/*
== Operadores Aritmeticos
int soma = numero1 + numero2;
Console.WriteLine(soma); 

int subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

int multiplicacao = (numero2 * numero1) * 10;
Console.WriteLine(multiplicacao);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);
*/

/*

== Operadores relacionais
bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool menorOuIgual = numero1 <= numero2;
Console.WriteLine(menorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);
*/

/*
== Operadores lõgicos
var valido = numero2 > numero1 && 8 > 7;
Console.WriteLine(valido);

var valido2 = numero2 > numero1 || 6 > 7;
Console.WriteLine(valido2);

var valido3 = !(numero2 > 10);
Console.WriteLine(valido3);
*/

/*
== Operador ternario
bool ativo = true;
string status = ativo == true ? "Cadastro Ativo" : "Cadastro Inativo";
Console.WriteLine(status);
*/

/*

=== Primeira Funçao
 escreverNome();

void escreverNome()
{
    var nome = nomeCompleto();
    var soma = somarValores();
}

string nomeCompleto() 
{

    string primeiroNome = "Rafael";
    string segundoNome = "Almeida";
    return primeiroNome + " " + segundoNome;
}

var nome = nomeCompleto();
Console.WriteLine(nome);

int somarValores()
{
    return 8 + 2 ;
    
}
 int soma = somarValores();    
Console.WriteLine(soma);

*/

/*

=== Funcao com parametros

var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Rafael",  33 );
Console.WriteLine(nome);
int SomaValores(int a, int b)
{
    return a + b;
}

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}

*/

/*
=== ArrayList
using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1); // 0
arrayList.Add("Rafael"); //1
arrayList.Add(true); //2

Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);

// arrayList = new ArrayList();
arrayList.Clear();

foreach(var item in arrayList)
{
    Console.WriteLine(item);
}

*/

/*

=== ArrayTipado
//var arrayTipadoNumero = new int[3]{1, 2, 3};
var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

// Array.Resize(ref arrayTipadoNumero, 100);
// arrayTipadoNumero[10] = 100;

foreach(var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

// var arrayTipadoString = new string[2] {"Rafael", "Almeida"};
var arrayTipadoString = new string[2];
arrayTipadoString[0] = "Rafael";
arrayTipadoString[1] = "Almeida";

foreach(var item in arrayTipadoString)
{
    Console.WriteLine(item);
}

*/

/*
=== List

using System.Collections.Generic;

var lista = new List<string>(10)
{
    "Rafael",
    "Almeida"
};

//lista.Add("Rafael");
//lista.Add("Almeida");
//lista.Add("Curso");

var nome = lista[0];
Console.WriteLine(nome);

lista.RemoveAt(1);

foreach(var item in lista)
{
    Console.WriteLine(item);
}

*/

/*
=== Dictionary

var dicionario = new Dictionary<string, string>()
{
    {"teste", "Teste"},
    {"teste6", "Teste 6"}
};

dicionario.Add("nome", "Rafael");

dicionario["curso"] = "Curso";
var nome = dicionario["curso"];

// Console.WriteLine(nome);

foreach(var item in dicionario)
{
    Console.WriteLine(item.Value);
}

*/


/*
=== Queue
var queue = new Queue<string>();
queue.Enqueue("Rafael");
queue.Enqueue("Almeida");

//var nome = queue.Dequeue();
//var nome1 = queue.Dequeue();

var nome = queue.Dequeue(); // Primeira Execucao
var nome1 = queue.Dequeue(); // Segunda Execucao

Console.WriteLine(nome);
Console.WriteLine(nome1);

/*
foreach(var item in queue)
{
    Console.WriteLine(item);

}
*/

/*
=== Stack
var stack = new Stack<string>();
stack.Push("Rafael");
stack.Push("Almeida");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);

/*
foreach(var item in stack)
{
    Console.WriteLine(item);    
}
*/

/*var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho)
{
    Console.WriteLine("Hoje é domingo");
} 
else if (diaDaSemana == 0 && diaDeTrabalho == false)  
{
    Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
}
 else 
{
    Console.WriteLine("Hoje não é domingo");
}
*/

/* IF ELSE ELSE IF
var diaDaSemana = 6;
if(diaDaSemana == 0) 
{
    Console.WriteLine("Hoje é domingo");
}
else if (diaDaSemana == 1)
{
    Console.WriteLine("Hoje é segunda-feira");
}
else if (diaDaSemana == 2)
{
    Console.WriteLine("Hoje é terça-feira");
}
else if (diaDaSemana == 3)
{
    Console.WriteLine("Hoje é quarta-feira");
}
else if (diaDaSemana == 4)
{
    Console.WriteLine("Hoje é quinta-feira");
}
else if (diaDaSemana == 5)
{
    Console.WriteLine("Hoje é sexta-feira");
}
else if (diaDaSemana == 6)
{
    Console.WriteLine("Hoje é sábado");
}
else
{
    Console.WriteLine("Dia da semana inválido!");
}

*/

/*
 === Switch
var diaDaSemana = 0;

switch(diaDaSemana)
{
    case 0 :
    Console.WriteLine("Hoje é domingo");
    break;

        case 0 :
    Console.WriteLine("Hoje é domingo");
    break;

        case 1 :
        Console.WriteLine("Hoje é segunda-feira");
        break;

        case 2 :
        Console.WriteLine("Hoje é terça-feira");
        break;

        case 3 :
        Console.WriteLine("Hoje é quarta-feira");
        break;

        case 4 :
        Console.WriteLine("Hoje é quinta-feira");
        break;

        case 5 :
        Console.WriteLine("Hoje é sexta-feira");
        break;

        case 6 :
        Console.WriteLine("Hoje é sábado");
        break;

        default :
        Console.WriteLine("Dia da semana inválido");
        break;
}

var diaDaSemana = 0;
switch(diaDaSemana < 1)
{
    case true: 
    Console.WriteLine("Hoje é domingo");
    break;

    case false: 
    Console.WriteLine("Dia da semana inválido");
    break;
}

*/


/* 
=== For
var lista = new List<string>() { "Rafael", "Curso", "C#"};
var count = lista.Count;
for(var i = 0; i < lista.Count; i++ )
{
    var nome = lista[i];

    Console.WriteLine(nome);
}

*/


/*
=== Foreach
var lista = new List<string>() { "Rafael", "Curso", "C#"};

/*foreach(var item in lista)
{
    Console.WriteLine(item);
}
*/
/*
foreach(var letra in "Rafael Almeida")
{
    Console.WriteLine(letra);
}

*/


/*
=== While 
var i = 0;
while(i < 10)
{
    Console.WriteLine(i);
    i++;
}

var j = 0;

do
{
    Console.WriteLine(j);
    j++;
} while (j < 10);

var i = 0;
while(i < 5)
{
    if(i <2)
    {
     Console.WriteLine("Continuando...");
     i++;
     continue;   
    }
    Console.WriteLine("var i = " + i);
    i++;

    if( i == 2)
    {
        Console.WriteLine("Valor de i é igual a 2 (dois)");
        break;
    }
}

*/