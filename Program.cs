using System;

namespace arayuz_ornek
{
    class program
    {
        public static void Main(string[] args)
        {
            Focus focus = new Focus();
            System.Console.WriteLine(focus.HangiMarkaninAraci()); 
            System.Console.WriteLine(focus.KacTekerlekOlusur()); 
            System.Console.WriteLine(focus.StandartRegiNe()); 

            Civic civic = new Civic();
            System.Console.WriteLine(civic.HangiMarkaninAraci()); 
            System.Console.WriteLine(civic.KacTekerlekOlusur()); 
            System.Console.WriteLine(civic.StandartRegiNe()); 

            Corolla corolla = new Corolla(); 
            System.Console.WriteLine(corolla.HangiMarkaninAraci()); 
            System.Console.WriteLine(corolla.KacTekerlekOlusur()); 
            System.Console.WriteLine(corolla.StandartRegiNe());
            
        }
    }   

}