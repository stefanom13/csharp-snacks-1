//snack10
//fai inserire un numero, che chiameremo N, all utente
//genera N array, ognuno formato da 10 numeri casuali tra 10 e 100, 
//ogni volta che crei un array stampalo a schermo

Random rnd = new Random();
int numb = rnd.Next();
Console.Write("Inserire un numero: ");
int arrays = Int32.Parse(Console.ReadLine());

for (int i = 0; i < arrays; i++)
{
    int[] randomNumberArray = new int[10];
    for (int j = 0; j < 10; j++)
    {
        randomNumberArray[j] = rnd.Next(10, 100);
        Console.Write(randomNumberArray[j]);
        if (j < 10 - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("\n");

}




return;
//snack5
//il software chiede all utente un numero, se è pari viene stampato, se dispari stampo numero successivo

Console.Write("Inserisci un numero");
int numero = Int32.Parse(Console.ReadLine());



if ( numero % 2 != 0)
{
    Console.WriteLine(numero + 1);
}
else
{
    Console.WriteLine(numero);
}


return;

//snack4
//Calcola la somma e la media dei numeri da 2 a 10;

int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int numeroSomma = 0;
float media;

for (int i = 0; i < numeri.Length; i++)
{
    numeroSomma += numeri[i];
}

media = numeroSomma / numeri.Length;

Console.WriteLine($"La somma dei numeri è: {numeroSomma}. La media dei numeri è: {media}");
return;

//snack3
//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.


Console.Write("Inserisci Dieci numeri");

   int somma = 0;
     for (int i = 0; i < 10; i++)
     {       
        int userNumber = Int32.Parse(Console.ReadLine());
         somma += userNumber;
     }

   Console.WriteLine("La somma totale dei numeri inseriti è:" + somma);
        
    