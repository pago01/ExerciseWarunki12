using System;
using System.ComponentModel.Design;

namespace ExerciseWarunki12
{
    //Data structure declaration

    class Program
    {
        private static void Main(string[] args)
        {
            int ocena = 0;
            string opis = "";
            bool parseresult;
            //Score read
            do
            {
                Console.WriteLine("Podaj dzień tygodnia od 1 do 7");
                parseresult = Int32.TryParse(Console.ReadLine(), out ocena);
            }
            while (!parseresult || ocena < 1 || ocena > 7);


            //Score description
            switch (ocena)
            {
                case 1:
                    opis = "poniedziałek";
                    break;
                case 2:
                    opis = "wtorek";
                    break;
                case 3:
                    opis = "środa";
                    break;
                case 4:
                    opis = "czwartek";
                    break;
                case 5:
                    opis = "piątek";
                    break;
                case 6:
                    opis = "sobota";
                    break;
                case 7:
                    opis = "sobota";
                    break;
                default:
                    opis = "niepoprawne dane";
                    break;
            }
            Console.WriteLine(opis);
        }
    }
}
