class Program
{
    static void Main()
    {
        Console.Write("Digite um número X: ");
        int X = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= X)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}
