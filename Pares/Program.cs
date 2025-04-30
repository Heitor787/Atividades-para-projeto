class Program
{
    static void Main()
    {
        Console.Write("Digite um número X: ");
        int X = int.Parse(Console.ReadLine());

        int numero = 2;

        while (numero <= X)
        {
            Console.WriteLine(numero);
            numero += 2;
        }
    }
}
