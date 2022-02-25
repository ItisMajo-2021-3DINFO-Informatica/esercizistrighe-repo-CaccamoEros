using System;

namespace CaccamoGeneratorePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2;
            numeri[2] = 3;
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6;
            numeri[6] = 7;
            numeri[7] = 8;
            numeri[8] = 9;
            numeri[9] = 0;
            char[] alfabeto = new char[26];
            alfabeto[0]= 'a';
            alfabeto[1]= 'b';
            alfabeto[2]= 'c';
            alfabeto[3]= 'd';
            alfabeto[4]= 'e';
            alfabeto[5]= 'f';
            alfabeto[6]= 'g';
            alfabeto[7]= 'h';
            alfabeto[8]= 'i';
            alfabeto[9]= 'j';
            alfabeto[10]= 'k';
            alfabeto[11]= 'l';
            alfabeto[12]= 'm';
            alfabeto[13]= 'n';
            alfabeto[14]= 'o';
            alfabeto[15]= 'p';
            alfabeto[16]= 'q';
            alfabeto[17]= 'r';
            alfabeto[18]= 's';
            alfabeto[19]= 't';
            alfabeto[20]= 'u';
            alfabeto[21]= 'v';
            alfabeto[22]= 'w';
            alfabeto[23]= 'x';
            alfabeto[24]= 'y';
            alfabeto[25]= 'z';
            char[] simboli = new char[10];
            simboli[0] = '!' ;
            simboli[1] = '£' ;
            simboli[2] = '$' ;
            simboli[3] = '%' ;
            simboli[4] = '&' ;
            simboli[5] = '/' ;
            simboli[6] = '(' ;
            simboli[7] = ')' ;
            simboli[8] = '=' ;
            simboli[9] = '?' ;
            string[] parole = new string[10];
            parole[0] = "ciao";
            parole[1] = "carte";
            parole[2] = "pesca";
            parole[3] = "triangolo";
            parole[4] = "vecchio";
            parole[5] = "strano";
            parole[6] = "casa";
            parole[7] = "portachiavi";
            parole[8] = "cavallo";
            parole[9] = "banana";
            Console.WriteLine("indica la lunghezza della tua password");
            int lunghezza = Convert.ToInt32(Console.ReadLine());
            string NuovaPassword = "";
            Random generatore = new Random();
            for (int i = 0; i < lunghezza; i++)
            {
                int SceltaMazzo = generatore.Next(1, 5);
                if (SceltaMazzo == 1)
                {
                    int IndiceAlfabeto = generatore.Next(1, 26);
                    NuovaPassword = NuovaPassword + alfabeto[IndiceAlfabeto];
                }
                else if (SceltaMazzo == 2)
                {
                    int IndiceNumeri = generatore.Next(1, 10);
                    NuovaPassword = NuovaPassword + numeri[IndiceNumeri];
                }
                else if (SceltaMazzo == 3)
                {
                    int IndiceSimboli = generatore.Next(1, 10);
                    NuovaPassword = NuovaPassword + simboli[IndiceSimboli];
                }
                else if (SceltaMazzo == 4)
                {
                    int IndiceParole = generatore.Next(1, 10);
                    NuovaPassword = NuovaPassword + parole[IndiceParole];
                }
            }
            Console.WriteLine("la tua password è ");
            Console.WriteLine(NuovaPassword);






        }
    }
}
