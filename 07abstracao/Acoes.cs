abstract class Acoes
{

    // Métodos obrigatórios
    public abstract void Falar();
    public abstract void Andar();

    // Métodos opcionais
    public void Pular()
    {
        Console.WriteLine("Estou pulando...");
    }

}