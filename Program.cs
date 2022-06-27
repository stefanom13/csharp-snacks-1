namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci Dieci numeri");
            int somma = 0;

            for (int i = 0; i < 10; i++)
            {
                
                int userNumber = Int32.Parse(Console.ReadLine());
                somma += userNumber;
            }

            Console.WriteLine("La somma totale dei numeri inseriti è:" + somma);
        }
    }
}