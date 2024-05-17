namespace Listas;

public class Lista <T>
{
    private string? Nome { get; set; }
    private string? Idade { get; set; }
    private List <T> Listagem { get; set; }

    public void Adicionar<T>(T nomes)
    {
        Listagem.Add(nomes);
    }
    
    public void Listar (string predicado)
    {
     var ord = Listagem.FindAll(x => x.Equals(predicado));

     foreach (var i in ord)
     {
         Console.WriteLine(i);
     }
    }

    public Lista(string? nome, string? idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Lista()
    {
    }
    
}