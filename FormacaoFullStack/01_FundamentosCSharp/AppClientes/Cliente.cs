namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime CadastradoEm { get; set; }
    public Decimal Desconto { get; set; }

}