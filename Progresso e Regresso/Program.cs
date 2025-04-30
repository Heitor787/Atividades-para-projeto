class Program
{
    static void Main()
    {
        int contador = 10;

        
        Console.WriteLine("Contagem de 10 até 1:");
        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }

       
        contador = 1;
        Console.WriteLine("\nContagem de 1 até 10:");
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}
