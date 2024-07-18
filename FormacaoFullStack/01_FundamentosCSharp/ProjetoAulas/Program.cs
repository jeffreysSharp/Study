// Console.WriteLine("Primeiro programa");

public class Program
{
    
    static void Main(string[] args)
    {
        // AulaClasses();      
        // AulaPropriedadeSomenteLeitura();
        // AulaHeranca();
        // AulaHerAulaClasseSelada();
        // AulaClasseAbstrata();
        // AulaRecord();
        // AulaInterface();   
        // Conversores(); 
        // TrabalhandoComStrings();
        // TrabalhandoComDatas();        
        // TrabalhandoComExcessoes();
        // TrabalhandoComArquivos();
        TrabalhandoComLinq();
    }

    private static void TrabalhandoComLinq()
    {
        var linq = new Modulo14.TrabalhandoComLinq();
        // linq.AulaWhere();
        // linq.AulaOrdenacao();
        // linq.AulaTake();
        // linq.AulaCount();
        linq.AulaFirstEFirstOrDefault();
    }

    private static void TrabalhandoComArquivos()
    {
        var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
        // trabalhandoComArquivos.AulaCriandoArquivo();
        // trabalhandoComArquivos.AulaLendoArquivo();
        trabalhandoComArquivos.AulaExcluindoArquivo();
    }

    private static void TrabalhandoComExcessoes()
    {
        var trabalhandoComExcessoes = new Modulo12.TrabalhandoComExcessoes();
        // trabalhandoComExcessoes.AulaGerandoException();
        trabalhandoComExcessoes.AulaTratandoException();

    }

    private static void TrabalhandoComDatas()
    {
        var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
        // trabalhandoComDatas.AulaDateTime();
        // trabalhandoComDatas.AulaSubtraindoDatas();
        // trabalhandoComDatas.AulaAdicionandoDiasMesAno();
        // trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundo();
        // trabalhandoComDatas.AulaDiaDaSemana();
        // trabalhandoComDatas.AulaDateOnly();
        trabalhandoComDatas.AulaTimeOnly();

    }

    private static void TrabalhandoComStrings()
    {
        var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
        //trabalhandoComStrings.ConverterParaLetrasMinusculas();
        //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
        //trabalhandoComStrings.AulaSubstring();
        //trabalhandoComStrings.AulaRange();
        //trabalhandoComStrings.AulaContains();
        //trabalhandoComStrings.AulaStartWithEndsWith();
        //trabalhandoComStrings.AulaReplace();
        trabalhandoComStrings.AulaLenght();
    }

    private static void Conversores()
    {
        var conversores = new Conversores.Conversor();
        //cnversores.ConvertAndParse();
        conversores.AulaTryParse();
    }

    /*
    private static void AulaInterface()
    {
        var notificacaoCliente = new Cadastro.NotificacaoCliente();
        notificacaoCliente.Notificar();
        notificacaoCliente.NotificarOutros();

        Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
        notificacao.Notificar();
        
    }
    */
    private static void AulaRecord()
    {
        // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
        // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};

        var curso1 = new Cadastro.Curso(1, "Curso");
        var curso2 = curso1 with {Descricao = "Teste novo"};
        
        // var curso1 = new Cadastro.CursoTeste  { Id = 1, Descricao = "Curso"};
        // var curso2 = curso1;
        // curso2.Descricao = "TESTE TESTE";
        // var curso2 = new Cadastro.CursoTeste();
        // curso2.Id = curso1.Id;
        // curso2.Descricao = "Nova Descricao";

        Console.WriteLine(curso1.Descricao);
        Console.WriteLine(curso2.Descricao);

        // Console.WriteLine(curso1.Equals(curso2));
        // Console.WriteLine(curso1 == curso2);
    }

    private static void AulaClasseAbstrata()
    {
        var cachorro = new Cadastro.Cachorro();
        cachorro.nome = "Dog";
        cachorro.ImprimirDados();

    }

    private static void AulaHerAulaClasseSelada()
    {
        // var configuracao = new Cadastro.Configuracao();
        // configuracao.Host = "localhost";

        var configuracao = new Cadastro.Configuracao
        {
            Host = "localhost"
        };

        Console.WriteLine(configuracao.Host);

    }


    private static void AulaHeranca()
    {
        /*var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Endereco Teste";
        pessoaFisica.Cidade = "Cidade Teste";
        pessoaFisica.Cep = "09961010";
        pessoaFisica.CPF = "29492873877";

        pessoaFisica.ImprimirDados();
        pessoaFisica.ImprimirCPF(); */

        var funcionario = new Cadastro.PessoaFisica();
        funcionario.Id = 1;
        funcionario.Endereco = "Endereco Teste";
        funcionario.Cidade = "Cidade Teste";
        funcionario.Cep = "09961010";
        funcionario.CPF = "29492873877";

        funcionario.ImprimirDados();
        funcionario.ImprimirCPF();
    }

    private static void AulaClasses()
    {
        var resultado = Cadastro.Calculos.SomarNumeros(2,3);
        Console.WriteLine(resultado);

        /*
        var produto = new Cadastro.Produto();
        produto.SetId(1);

        produto.Descricao = "Teclado";

        produto.ImprimirDescricao();
        Console.WriteLine(produto.GetId());
        */

    }

    private static void AulaPropriedadeSomenteLeitura()
    {
        var produto = new Cadastro.Produto();
        produto.Descricao = "Mouse";
        // produto.Estoque = 1;
        Console.WriteLine(produto.Estoque);

    }
}
