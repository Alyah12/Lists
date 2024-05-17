namespace Listas;

public class Lista
{
    private string? Nome { get; set; }
    private string? Idade { get; set; }
    public List<string> Listagem { get; set; }

    public void Adicionar(string [] nomes)
    {
        Listagem.AddRange(nomes);
    }
    
    public void Listar (string predicado)
    {
     var ord =Listagem.FindAll(x => x.Equals(predicado));

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