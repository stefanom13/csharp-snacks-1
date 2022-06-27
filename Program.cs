namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Inserire il numero: ");
                int userNumber = Int32.Parse(Console.ReadLine());
                somma += userNumber;
            }

            Console.WriteLine(somma);
        }
    }
}