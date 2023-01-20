namespace arayuz_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlekOlusur()
        {
            return 4;
        }

        public Renk StandartRegiNe()
        {
            return Renk.Beyaz;
        }
    }
}