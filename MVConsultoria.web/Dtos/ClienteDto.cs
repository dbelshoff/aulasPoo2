public class ClienteDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public DateTime DiaDePagamento { get; set; }
    public decimal LimiteDeCredito { get; set; }
    public decimal LimiteDisponivel { get; set; }
    public bool Bloqueado { get; set; }
}
