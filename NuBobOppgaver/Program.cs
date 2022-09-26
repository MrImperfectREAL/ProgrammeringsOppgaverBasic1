using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuBobOppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel();
        }

        //Oppgave 1
        static void First10Numbers()
        {
            //lager array
            int[] NatNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //summerer alle integers i arrayen regardless av lengden til arrayen
            for (int i = 0; i < NatNum.Length; i++)
            {
                //summerer alle tallene
                int sum = NatNum.Sum();
                //clearer alle de outputsene som ikke trengs som kommer fra for loopen
                //dette må brukes fordi vis du prøver å skrive sum utenfor denne loopen
                //eller definere den først utenfor så funker det bare ikke.
                Console.Clear();
                Console.WriteLine(sum);
            }
        }

        //Oppgave 2
        static void InputTall()
        {
            Console.WriteLine("Please write an integer");
            //leser in et input
            int n = int.Parse(Console.ReadLine());
            //gjør sånn at arrayen er lik lengden som useren inputter men +1 sånn at arrayen ikke crasher
            //fra å være full
            int[] NatNum = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                //gjør sånn at plass 1=1, plass 2=2 osv.
                NatNum[i] = i;
                //summerer alle tallene
                int sum = NatNum.Sum();
                Console.Clear();
                //printer summen og størrelsen på tabellen
                Console.WriteLine(sum);
                Console.WriteLine("Summen av de " + NatNum[i] + " første naturlig tallene");
            }
        }

        //Oppgave 3
        static void InputTallExpanded()
        {
            //definerer arrayen som 10 i størrelse (begynner på 0 men den 10ene plassen kan ikke brukes
            int[] NatNum = new int[10];

            //legger til 10 user inputs til arrayen Natnum

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input a number, your current number is " + (i+1) + " out of 10");
                int n = int.Parse(Console.ReadLine());
                NatNum[i] = n;
            }

            //summerer alle inputsene
            int sum = NatNum.Sum();
            //finner gjennomsnittet av alle inputs
            double average = NatNum.Average();

            //skriver ut alt som ble inputtet
             foreach (int item in NatNum)
             {
                Console.WriteLine("The inputted numbers are: " + item);
             }

            //Skriver ut summen
            Console.WriteLine("The sum of your inputs is: " + sum);
            //Skriver ut gjennomsnittet
            Console.WriteLine("The average of your inputs is: " + average);
        }

        //Oppgave 4
        static void InputTallPrint()
        {
            //er basically det samme som forje men uten average og sum 
            int[] NatNum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input a number, your current number is " + (i + 1) + " out of 10");
                int n = int.Parse(Console.ReadLine());
                NatNum[i] = n;
            }  

                foreach (int item in NatNum)
                {
                    Console.WriteLine("The inputted numbers are: " + item);
                }

        }

        //oppgave 5
        static void InputTallPrintReverse()
        {
            int[] NatNum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input a number, your current number is " + (i + 1) + " out of 10");
                int n = int.Parse(Console.ReadLine());
                NatNum[i] = n;
            }

            //lager en loop som reverser posisjonen av tallene i arrayen meg å ta den første
            //halvdelen forran den andre halvdelen
            for (int i = 0; i < NatNum.Length / 2; i++)
            {
                int temp = NatNum[i];
                NatNum[i] = NatNum[NatNum.Length - i - 1];
                NatNum[NatNum.Length - i - 1] = temp;
            }

            //skriver ut loopen i riktig rekkefølge
            foreach (int item in NatNum)
            {
                Console.WriteLine("The inputted numbers are: " + item);
            }
        }

        //Oppgave 6
        static void PrintBiggest()
        {
            //definerer den minste og største størrelsen som random tallene kan bli
            int Min = 0;
            int Max = 100;

            //gjør arrayen 50 i størrelse som spurt av oppgaven
            int[] RandomArray = new int[50];

            //fyller arrayen med randome tall fra 0-100
            Random randNum = new Random();
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = randNum.Next(Min, Max);
            }

            //gjør en index som finner det største tallet i arrayen
            int maxValue = RandomArray.Max();
            int maxIndex = RandomArray.ToList().IndexOf(maxValue);

            //printer resultatet av indexen
            Console.WriteLine("The largest randomized number is: " + maxValue);
        }

        //Oppgave 7
        static void RisingNumbers()
        {
            //en array med forskjellige tall lagd av meg
            int[] Num = { 32, 5, 97, 1, 24 };

            //bruker sorter metoden for å sortere dem i en rising order
            Array.Sort(Num);

            //printer ut alt i arrayen
            foreach (int item in Num)
            {
                Console.WriteLine("The Array's numbers in order are: " + item);
            }

        }

        //Oppgave 8
        static void ArrayMake()
        {
            Console.WriteLine("How long do you want to make the Array?");

            //definerer lengden av arrayen som inputten, lånt fra oppgave 2
            int n = int.Parse(Console.ReadLine());
            int[] Num = new int[n];

            //lar brukeren definere alle tallene i arrayen, også lånt fra oppgave 2
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input a number, your current number is " + (i+1) + " out of " + n);
                int j = int.Parse(Console.ReadLine());
                Num[i] = j;
            }

            //printer ut alle tallene inputtet
            foreach (int item in Num)
            {
                Console.WriteLine("The Array's numbers are: " + item);
            }
        }

        //Oppgave 9
        static void FindOdd()
        {
            int i = 0;
            int[] Num = new int[5];

            //legger til user input til arrayen
            Console.WriteLine("Please add numbers to the array.");
            for (i = 0; i < Num.Length; i++)
            {
                Console.Write("You are currently on number " + (i + 1) + " out of 5, add a number: ");
                Num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("These are the odd number(s) you added: ");
            for (i = 0; i < Num.Length; i++)
            {
                //bruker module funksjon for å sjekke om integeren er et odde tall ved å se om den deles i to
                //med null rest fra hel tallene, og printer ut tallet vis det er rest
                if (Num[i] % 2 != 0)
                    Console.Write(Num[i] + " ");
            }
            Console.WriteLine();
        }

        //oppgave 10
        static void NumberTriangle()
        {
            //definerer integersene som skal brukes senere 
            int i, j, rows;

            Console.Write("What number do you want the triangle to be made out of? ");

            int trianglenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("How long do you want the triangle to be? Input number of rows :");

            //tar input for hvor lang trianglen skal bli
            rows = Convert.ToInt32(Console.ReadLine());

            //lager en loop innenfor en loop som printer ut triangel på måten oppgaven ville ha
            //fordi triangelen kan ikke bli særlig mye lengre enn 30 så er det greit å bruke en for loop
            //innenfor en annen for loop
            for (i = rows; i >0; i--)
            {
                for (j = 0; j <= i-1; j++)
                    Console.Write("{0}", trianglenumber);
                Console.Write("\n");
            }

        }
        //oppgave 11
        static void Hotel()
        {
            Console.WriteLine("You're going to make a Hotel.\n\n ");
            Console.WriteLine("What are you naming it? ");
            //definerer hotel navn
            string Name = Console.ReadLine();

            Console.WriteLine("\nHow many rooms does it have? ");
            //definerer hvor mange rom hotellet har
            int Room = int.Parse(Console.ReadLine());

            //gir hotelet et true/false system for ledig/ikke ledig som er veldig effecient
            bool[]Hotel = new bool[Room];

            Console.WriteLine("\nHow many rooms are being used? ");
            //definerer hvor mange blir brukt
            int n = int.Parse(Console.ReadLine());

            //gjør alle rommene helt til n tatt, er ikke helt realistisk men funker for denne funksjonaliteten
            for (int i = 0; i <= n; i++)
            {
                Hotel[i] = true;
            }

            //regner ut hvor mange rom er ledig
            int RemainingRooms = Room - n;

            //printer alle resultatene
            Console.WriteLine("\n" + Name + " has " + Room + " rooms total, " + n + " taken, and " + RemainingRooms + " remaining.");
        }
    }
}
