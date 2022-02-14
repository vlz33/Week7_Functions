using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutala sisestada eesnimi;
            //programm palub kasutajal sisestada number 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja ja valib '3', siis kuvatakse kasutaja eesnime pikkus;
            //kolm viimast funktsiooni abil;

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Siseta number '1', '2', või '3'");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            switch (userNumber)
            {
                case 1:
                    UserNameBackwards(userName);
                    break;
                case 2:
                    UserNameFirstLetter(userName);
                    break;
                case 3:
                    UserNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Proovi uuesti sisestada number 1-3");
                    break;
            }
        }

        public static void UserNameBackwards(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
        }

        public static void UserNameFirstLetter(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
        }
        public static void UserNameLength(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk");
        }

    }

}
