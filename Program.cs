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

            System.Console.WriteLine("*** NEW CARS ***");
            NewFocus newFocus = new NewFocus();
            System.Console.WriteLine(newFocus.HangiMarkaninAraci()); 
            System.Console.WriteLine(newFocus.KacTekerlekOlusur()); 
            System.Console.WriteLine(newFocus.StandartRegiNe()); 

            NewCivic newCivic = new NewCivic();
            System.Console.WriteLine(newCivic.HangiMarkaninAraci()); 
            System.Console.WriteLine(newCivic.KacTekerlekOlusur()); 
            System.Console.WriteLine(newCivic.StandartRegiNe()); 

            NewCorolla neworolla = new NewCorolla(); 
            System.Console.WriteLine(neworolla.HangiMarkaninAraci()); 
            System.Console.WriteLine(neworolla.KacTekerlekOlusur()); 
            System.Console.WriteLine(neworolla.StandartRegiNe());

            
        }
    }   

}