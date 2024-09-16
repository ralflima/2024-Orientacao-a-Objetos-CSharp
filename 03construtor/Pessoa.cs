class Pessoa
{
    // 1º construtor
    public Pessoa()
    {
        Console.WriteLine("Hello World!");
    }

    // 2º construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    // 3º construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome} você tem {idade} anos.");
    }

}