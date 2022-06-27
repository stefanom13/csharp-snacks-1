

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
        
    