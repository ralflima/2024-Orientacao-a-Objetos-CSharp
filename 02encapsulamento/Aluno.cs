class Aluno
{
    // 1º maneira
    private string? _nome;

    public string? Nome
    {
        get{ return _nome; }
        set{ _nome = value; }
    }

    // 2ª maneira (.NET 6+)
    public double Media { get; set; }
}