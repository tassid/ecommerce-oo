public abstract class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public CategoriaProduto Categoria { get; set; }
}

public enum CategoriaProduto
{
    Camiseta,
    Calca,
    Sapato,
    Bolsa,
    Acessorio
}
