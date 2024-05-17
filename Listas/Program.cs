using Listas;

class Program
{
    public static void Main(string[] args)
    {
        Lista lista = new Lista();
        
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a idade");
        string idade = Console.ReadLine()!;
        
        lista.Adicionar(nome);
        lista.Adicionar(idade);
        
        lista.Listar("Lucas");
    }  
}