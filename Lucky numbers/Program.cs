namespace Lucky_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosli u Lucky 6 Igru!");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
            int[] mojiBr = new int[6];
            int[] randomBr = new int[6];
            Random rnd = new Random();
            bool igrajPonovo = true;

            while (igrajPonovo)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Unesite vasih 6 srecnih brojeva: (1-48) \n");
                    mojiBr[i] = int.Parse(Console.ReadLine());
                    while (mojiBr[i] < 1 || mojiBr[i] > 48)
                    {
                        Console.WriteLine("Brojevi moraju biti u opsegu 1-48 \n");
                        mojiBr[i] = int.Parse(Console.ReadLine());

                    }
                }

                for (int i = 0; i < 6; i++)
                {

                    randomBr[i] = rnd.Next(1, 49);
                }

                Console.WriteLine($"Kompjuterski brojevi su : " + String.Join(", ", randomBr));
                Console.WriteLine();
                Console.WriteLine($"Korisnikovi brojevi su: " + String.Join(", ", mojiBr));

                int brPogodaka = 0;
                foreach (int broj in mojiBr)
                {
                    if (randomBr.Contains(broj))
                    {
                        brPogodaka++;

                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Broj pogodjenih : {brPogodaka}");
                
               // Console.ForegroundColor = ConsoleColor.White;
                Console.ResetColor();
                Console.WriteLine();

                if(brPogodaka == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cestitamo! Osovojli ste 100 dinara.");
                }
                else if(brPogodaka == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cestitamo! Osovojli ste 500 dinara.");
                }
                else if (brPogodaka == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cestitamo! Osovojli ste 2500 dinara.");
                }
                else if (brPogodaka == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Osvojli ste 10.000 dinara.");
                }
                else if( brPogodaka == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Osvojli ste 50.000 dinara ");
                }
                else if (brPogodaka == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Osvojli ste 500.000 dinara.");
                }
                else if(brPogodaka == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niste osvojili nista.");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Da li zelite da igrate ponovo? (D/N)");
                string odg = Console.ReadLine().ToUpper();
                if(odg == "N")
                {
                    igrajPonovo = false;
                    Console.WriteLine("Hvala sto ste igrali sa nama.");
                    break;
                }
                else if(odg == "D")
                {
                    igrajPonovo = true;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Neispravan unos.");
                    odg = Console.ReadLine();
                }

            }
        }
    }
}
